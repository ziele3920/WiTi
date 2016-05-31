using System;
using System.Collections.Generic;
using System.Linq;

namespace WiTi
{
    public class ByteService
    {
        const string formatter = "{0,16}{1,20}";

        public byte[] IntToByte(int value, int byteLenghth)
        {
            string binary = Convert.ToString(value, 2);
            byte[] binaryArray = new byte[byteLenghth];
            for (int i = 0; i < binary.Length; ++i)
                binaryArray[i] = byte.Parse((binary[binary.Length-1-i].ToString()));

            return binaryArray;
        }

        public int ByteToInt(byte[] byteArray)
        {
            string binaryStr = "";
            for (int i = 0; i < byteArray.Length; ++i)
                binaryStr = binaryStr.Insert(0, byteArray[i].ToString());

            int o = Convert.ToInt32(binaryStr, 2);
            return o;
        }

        int GetCountOfSetBytes(byte[] array)
        {
            int count = 0;
            foreach (var byt in array)
                if (byt == 1)
                    ++count;
            return count;
        }

        public int[,] GetPermutationsIndex(int value, int byteLength)
        {
            byte[] byteArr = IntToByte(value, byteLength);
            
            List<int> onesIndex = new List<int>();
            byte[] workingArr = new byte[byteArr.Length];
            for (int i = 0; i < byteArr.Length; ++i)
            {
                if (byteArr[i] == 1)
                    onesIndex.Add(i);
                workingArr[i] = byteArr[i];
            }
            int[,] indexes = new int[onesIndex.Count, 2];
            if (indexes.GetLength(0) == 1)
            {
                indexes[0, 0] = 0;
                indexes[0, 1] = onesIndex[0] + 1;
                return indexes;
            }

                for (int i = 0; i < onesIndex.Count; ++i)
            {
                indexes[i, 1] = Program.TwoPowX(onesIndex[i]);
                if (i > 0)
                    workingArr[onesIndex[i - 1]] = 1;
                workingArr[onesIndex[i]] = 0;
                indexes[i, 0] = ByteToInt(workingArr);
            }
            return indexes;
        }
    }

}
