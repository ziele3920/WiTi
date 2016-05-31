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

            foreach (var b in binaryArray)
                Console.Write(b.ToString());
            Console.WriteLine("");

            return binaryArray;
        }

        public int ByteToInt(byte[] byteArray)
        {
            int length = byteArray.Length;
            string binaryStr = "";
            if (byteArray.Length % 8 != 0)
                length += 8 - byteArray.Length % 8;

            for (int i = 0; i < length; ++i)
            {
                if (i < byteArray.Length)
                    binaryStr += byteArray[i];
                else
                    binaryStr += 0;
            }
            string tmp = "";
            for(int i = length-1; i >= 0; --i)
            {
                tmp += binaryStr[i];
            }
            binaryStr = tmp;


            int o = Convert.ToInt32(binaryStr, 2);
            Console.WriteLine(o);
            return 0;
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
