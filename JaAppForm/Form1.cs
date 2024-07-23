using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JaDllCSharp.Class1;

namespace JaAppForm
{
    public partial class Form1 : Form
    {

        [DllImport(@"..\..\..\..\..\x64\Release\JaAsm.dll")]
        static extern uint ASMFuncUInt(uint[] a, uint b, uint c);
        //static extern uint MyProc1(ref uint a,  uint b, uint c);


        public Color colorToChange = Color.FromArgb(0, 0, 0);
        public Color colorToSet = Color.FromArgb(126, 0, 126);


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFile.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bool terazASM = false;
            //for (int z = 0; z < 2; z++)
            //{
            //    List<String> times = new List<string>();
            //    String nr_xd;
            //    if (terazASM) nr_xd = "ASM: ";
            //    else nr_xd = "C#: ";
            //    times.Add(nr_xd);
            //    for (int th = 1; th <= 64; th *= 2)
            //    {
            //        ThreadPool.SetMinThreads(th, th);
            //        ThreadPool.SetMaxThreads(th, th);
            //        String nr_proc = "Liczba wątków: ";
            //        nr_proc += th.ToString();
            //        times.Add(nr_proc);
            //        for (int tt = 0; tt < 50; tt++)
            //        {
                        Stopwatch stopWatch = new Stopwatch();

                        Bitmap copyBitmap = new Bitmap((Bitmap)pictureBox1.Image);


                        uint colorToChangeUInt = ColorToUInt(colorToChange);
                        uint colorToSetUInt = ColorToUInt(colorToSet);
                        int h = copyBitmap.Height, w = copyBitmap.Width;



                        List<Task<Tuple<int, int, uint[]>>> tasks2 = new List<Task<Tuple<int, int, uint[]>>>();
                        int border = (w * h) - ((w * h) % 8);

                        stopWatch.Start();
                        for (int i = 0; i < h * w; i += 8)
                        {
                            uint[] colors = new uint[8];
                            int howMany = 8;
                            if (i < border)
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    colors[j] = ColorToUInt(copyBitmap.GetPixel((i + j) / h, (i + j) % h));
                                }
                                howMany = 8;
                            }
                            else if (i == border)
                            {
                                int toDo = (w * h - border);
                                for (int j = 0; j < toDo; j++)
                                {
                                    colors[j] = ColorToUInt(copyBitmap.GetPixel((i + j) / h, (i + j) % h));
                                }
                                howMany = toDo;
                            }

                            tasks2.Add(Task<Tuple<int, int, uint[]>>.Factory.StartNew((Object obj) =>
                            {
                                Tuple<int, int, uint[]> checkedPixel = obj as Tuple<int, int, uint[]>;
                                uint[] colorsToEdit = new uint[8];
                                colorsToEdit = checkedPixel.Item3;

                                if (radioCSharp.Checked/*!terazASM*/) CSharpFuncUInt(ref colorsToEdit, colorToChangeUInt, colorToSetUInt);

                                if (radioASM.Checked/*terazASM*/) ASMFuncUInt(colorsToEdit, colorToChangeUInt, colorToSetUInt);



                                return new Tuple<int, int, uint[]>(checkedPixel.Item1, checkedPixel.Item2, colorsToEdit);
                            }, new Tuple<int, int, uint[]>(i, howMany, colors)
                            ));
                        }
                        Task.WaitAll(tasks2.ToArray());
                        stopWatch.Stop();



                        for (int i = 0; i < tasks2.Count; i++)
                        {
                            for (int j = 0; j < tasks2[i].Result.Item2; j++)
                            {
                                copyBitmap.SetPixel(((tasks2[i].Result.Item1 + j) / h), ((tasks2[i].Result.Item1 + j) % h), UIntToColor(tasks2[i].Result.Item3[j]));
                            }

                        }


                        TimeSpan time = stopWatch.Elapsed;
                        TimeLabel.Text ="Time: "+ time.ToString();
                        pictureBox2.Image = copyBitmap;
    //        times.Add(TimeLabel.Text);
    //    }

    //}
    //File.AppendAllLines(@"D:\Projekty\JA\Project\JaProj1\test4ASM.txt", times);
    //            terazASM = !terazASM;
    //        }
        }
        
        public uint ColorToUInt(Color colorBase)
        {
            uint color = 0;
            color += colorBase.A;
            color <<= 8;
            color += colorBase.R;
            color <<= 8;
            color += colorBase.G;
            color <<= 8;
            color += colorBase.B;
            return color;
        }
        public Color UIntToColor(uint colorBase)
        {
            Color color = Color.FromArgb((int)colorBase);
            return color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.Color = colorToChange;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                colorToChange = MyDialog.Color;
            LabelColorToChange.Text = "Kolor do podmiany:"+colorToChange.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.Color = colorToSet;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                colorToSet = MyDialog.Color;
            LabelColorToSet.Text = "Kolor do ustawienia:" + colorToSet.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ScrollThreads_Scroll(object sender, ScrollEventArgs e)
        {
            labelThreads.Text = "Liczba wątów: " + ScrollThreads.Value;
            ThreadPool.SetMinThreads(ScrollThreads.Value, ScrollThreads.Value);
            ThreadPool.SetMaxThreads(ScrollThreads.Value, ScrollThreads.Value);
        }


    }
}
