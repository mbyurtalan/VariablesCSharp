using System;

namespace Variables
{
    class Vars
    {
        public static void Main()
        {
            
            byte b = 1;             // 1 byte
            sbyte c = 1;            // 1 byte

            short s = 2;            // 2 byte
            ushort us = 2;          // 2 byte 

            Int16 i16 = 2;          // 2 byte
            int i = 4;              // 4 byte 
            Int32 i32 = 4;          // 4 byte
            Int64 i64 = 8;          // 8 byte

            uint ui = 4;            // 4 byte
            long l = 8;             // 8 byte
            ulong ul = 8;           // 8 byte

            // R
            float f = 4;            // 4 byte 
            double d = 8;           // 8 byte
            decimal de = 16;        // 16 byte 

            char chr = '2';         // 2 byte
            string str = "Mert";    // Sonsuz

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            object o1 = "x";
            object o2 = "y";
            object o3 = 2;
            object o4 = 2.7;

            // Stringler
            string str1 = string.Empty;
            str1 = "Mert";
            string name = "Mert";
            string midname = "Batuhan";
            string surname = "Yurtalan";
            string fullname = name + " " + midname + " " + surname;

            Console.WriteLine(fullname);

            // Integerlar

            int intg1 = 5;
            int intg2 = 3;
            int intg3 = intg1 + intg2;

            Console.WriteLine(intg3);

            // Bool

            bool boo0 = 1.75 > 1.5;
            bool boo1 = 1.25 > 1.5;
            Console.WriteLine("{0}, {1}", boo0, boo1);

            // VarConv
            string str5 = "5";
            int int5 = 5;
            string output = str5 + int5.ToString();

            Console.WriteLine(output);

            int int10 = int5 + Convert.ToInt32(str5);
            int int10_2 = int5 + int.Parse(str5);

            Console.WriteLine("{0}, {1}", int10, int10_2);

            // DateTime
            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime1);


            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);


            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    }
}