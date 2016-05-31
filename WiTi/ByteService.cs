using System;
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

        public int GetCountOfSetBytes(byte[] array)
        {
            int count = 0;
            foreach (var byt in array)
                if (byt == 1)
                    ++count;
            return count;
        }
    }

}
