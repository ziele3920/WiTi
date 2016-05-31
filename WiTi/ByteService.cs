using System;
using System.Linq;

namespace WiTi
{
    public class ByteService
    {
        const string formatter = "{0,16}{1,20}";

        public byte[] IntToByte(int value)
        {
            byte[] hexArray = BitConverter.GetBytes(value);
            byte[] binaryArray = HexArrayToBinaryByteArray(hexArray);
            return binaryArray;
        }

        public int ByteToInt(byte[] byteArray)
        {//////////////////////
            ////////////////////
            // TO DO 
            /////////////
            //foreach (var p in bytes)
            //    Console.WriteLine(p);
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

        byte[] HexArrayToBinaryByteArray(byte[] hexArray)
        {
            string bitstring = "";
            foreach (byte b in hexArray)
                bitstring += Convert.ToString(b, 2);
            byte[] binary = new byte[bitstring.Length];
            for (int i = 0; i < bitstring.Length; ++i)
                binary[i] = byte.Parse(bitstring[i].ToString());

            return binary;
        }

        
    }

}
