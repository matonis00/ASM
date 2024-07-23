
namespace JaAppForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.LabelColorToChange = new System.Windows.Forms.Label();
            this.LabelColorToSet = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radioCSharp = new System.Windows.Forms.RadioButton();
            this.radioASM = new System.Windows.Forms.RadioButton();
            this.ScrollThreads = new System.Windows.Forms.HScrollBar();
            this.labelThreads = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(832, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(601, 496);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1074, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Change Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(716, 577);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(45, 20);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "TIME:";
            // 
            // LabelColorToChange
            // 
            this.LabelColorToChange.AutoSize = true;
            this.LabelColorToChange.Location = new System.Drawing.Point(217, 664);
            this.LabelColorToChange.Name = "LabelColorToChange";
            this.LabelColorToChange.Size = new System.Drawing.Size(223, 20);
            this.LabelColorToChange.TabIndex = 5;
            this.LabelColorToChange.Text = "Kolor do podmiany: 255,255,255";
            // 
            // LabelColorToSet
            // 
            this.LabelColorToSet.AutoSize = true;
            this.LabelColorToSet.Location = new System.Drawing.Point(1043, 659);
            this.LabelColorToSet.Name = "LabelColorToSet";
            this.LabelColorToSet.Size = new System.Drawing.Size(210, 20);
            this.LabelColorToSet.TabIndex = 6;
            this.LabelColorToSet.Text = "Kolor do ustawienia: 126,0,126";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 707);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ustaw kolor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1062, 702);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "Ustaw kolor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioCSharp
            // 
            this.radioCSharp.AutoSize = true;
            this.radioCSharp.Checked = true;
            this.radioCSharp.Location = new System.Drawing.Point(716, 674);
            this.radioCSharp.Name = "radioCSharp";
            this.radioCSharp.Size = new System.Drawing.Size(48, 24);
            this.radioCSharp.TabIndex = 9;
            this.radioCSharp.TabStop = true;
            this.radioCSharp.Text = "C#";
            this.radioCSharp.UseVisualStyleBackColor = true;
            this.radioCSharp.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioASM
            // 
            this.radioASM.AutoSize = true;
            this.radioASM.Location = new System.Drawing.Point(716, 704);
            this.radioASM.Name = "radioASM";
            this.radioASM.Size = new System.Drawing.Size(61, 24);
            this.radioASM.TabIndex = 10;
            this.radioASM.TabStop = true;
            this.radioASM.Text = "ASM";
            this.radioASM.UseVisualStyleBackColor = true;
            this.radioASM.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ScrollThreads
            // 
            this.ScrollThreads.Location = new System.Drawing.Point(588, 780);
            this.ScrollThreads.Maximum = 73;
            this.ScrollThreads.Minimum = 1;
            this.ScrollThreads.Name = "ScrollThreads";
            this.ScrollThreads.Size = new System.Drawing.Size(326, 26);
            this.ScrollThreads.TabIndex = 11;
            this.ScrollThreads.Value = 12;
            this.ScrollThreads.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollThreads_Scroll);
            // 
            // labelThreads
            // 
            this.labelThreads.AutoSize = true;
            this.labelThreads.Location = new System.Drawing.Point(691, 815);
            this.labelThreads.Name = "labelThreads";
            this.labelThreads.Size = new System.Drawing.Size(122, 20);
            this.labelThreads.TabIndex = 12;
            this.labelThreads.Text = "Liczba wątów: 12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 873);
            this.Controls.Add(this.labelThreads);
            this.Controls.Add(this.ScrollThreads);
            this.Controls.Add(this.radioASM);
            this.Controls.Add(this.radioCSharp);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LabelColorToSet);
            this.Controls.Add(this.LabelColorToChange);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label LabelColorToChange;
        private System.Windows.Forms.Label LabelColorToSet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioCSharp;
        private System.Windows.Forms.RadioButton radioASM;
        private System.Windows.Forms.HScrollBar ScrollThreads;
        private System.Windows.Forms.Label labelThreads;
    }
}

