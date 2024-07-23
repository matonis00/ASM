using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaDllCSharp
{
    public class Class1
    {
        public static void CSharpFuncUInt(ref uint[] thatIs, uint colorToChangeUint, uint colorToSetUint)
        {
            for (int i = 0; i < 8; i++)
            {
                if (thatIs[i] == colorToChangeUint)
                    thatIs[i] = colorToSetUint;
            }

        }
    }
}
