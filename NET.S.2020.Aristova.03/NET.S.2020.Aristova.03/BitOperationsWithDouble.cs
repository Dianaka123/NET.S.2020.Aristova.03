using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp3
{
    public class BitOperationsWithDouble
    {
        [StructLayout(LayoutKind.Explicit, Size = sizeof(double))]
        private struct Converter
        {
            [FieldOffset(0)]
            public double DoubleValue;

            [FieldOffset(0)]
            public long IntValue;
        }
      
        public static string ConvertToBitStringCustom(double value)
        {
            int bitCount = sizeof(double) * 8; // количество битов

            long integerValue = ConvertToBitInt(value); 

            var result = new StringBuilder(bitCount);

            for (int i = 0; i < bitCount; i++)
            {
                var inverseIndex = bitCount - i - 1;
                result.Append(IsBit1(integerValue, inverseIndex) ? "1" : "0");
            }
            return result.ToString();
        }

        public static string ConvertToBitStringBuiltIn(double value) => // при помощи конвентатора
            Convert.ToString(BitConverter.DoubleToInt64Bits(value), 2);

        static long ConvertToBitInt(double value) => new Converter { DoubleValue = value }.IntValue; // делаем из double long
        static bool IsBit1(long value, int index) => (value & (1L << index)) != 0; // проверка на 1 или 0  в числе на месте index

    }
}
