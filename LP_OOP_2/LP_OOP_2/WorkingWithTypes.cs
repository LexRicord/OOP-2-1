using System;
using System.Text;
using System.Linq;

namespace LP_OOP_2
{
    class StudentName
    {
        public StudentName(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public override string ToString() => FirstName + "  " + ID;
    }


    class WorkingWithTypes
    {
        private static void ShowValue(int _)
        {
            byte[] arr = { 8, 1, 0, 0 };
            _ = BitConverter.ToInt32(arr, 0);
            Console.WriteLine(_);
        }

        static void Main(string[] args)
        {
            #region Types 
            #region Primitives_A
            sbyte sbyte1 = 4;       //Not compatible with CLS(Not)
            byte byte1 = 32;
            short short1 = 49;      //System.Int16
            ushort ushort1 = 100;   //Not
            int int1 = 128;        //System.Int32
            uint uint1 = 130;      //Not
            long long1 = 1000;      //System.Int64
            ulong ulong1 = 10000;   //Not
            char char1 = '0';
            float float1 = 32.32f;  //32-bit in IEEE
            double double1 = 3223.32d;
            bool bool1 = true;
            decimal decimal1 = 32132.30812488240324321231312m;     //128-bit with increased accuracy for financial calculations
            string string1 = "Alexander_Herman";
            var MyName1 = new StudentName("Alexander", "Herman");
            dynamic MyName2 = new StudentName("Alex", "German");

            Console.WriteLine($"Sbyte: {sbyte1} ");
            Console.WriteLine($"Byte type: {byte1}");
            Console.WriteLine(short1);
            Console.WriteLine($"Ushort1: {ushort1} ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Int32 type: {int1}");
            Console.WriteLine(uint1);
            Console.WriteLine(long1);
            Console.WriteLine(ulong1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Char type: {char1}");
            Console.WriteLine(float1);
            Console.WriteLine($"With floating point: {double1}");
            Console.WriteLine(bool1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The biggest integer type: {decimal1}");
            Console.WriteLine(float1);
            Console.WriteLine($"Name: {string1}");
            Console.WriteLine($"Name: {MyName1.FirstName}, Surname: {MyName1.LastName}");
            Console.WriteLine($"Name: {MyName2.FirstName}, Surname: {MyName2.LastName}");
            Console.ForegroundColor = ConsoleColor.Blue;
            #endregion
            #region Primitives_B
            short1 = sbyte1;
            long1 = int1;
            ulong1 = uint1;
            MyName1 = MyName2;
            double1 = float1;
            Console.WriteLine($"{short1} - {short1.GetType()},\n{long1} - {long1.GetType()},\n{ulong1} - {ulong1.GetType()}," +
                $"\n{MyName1} - {MyName1.GetType()},\n{double1} - {double1.GetType()},\n");

            byte1 = (byte)int1;
            string1 = Convert.ToString(decimal1);
            ulong1 = (ulong)int1;
            var string2 = Convert.ToString(MyName1);
            float1 = (float)sbyte1 + int1;

            Console.WriteLine($"{byte1} - {byte1.GetType()},\n{string1} - {string1.GetType()},\n{ulong1} - {ulong1.GetType()}," +
                $"\n{string2} - {string2.GetType()},\n{float1} - {float1.GetType()},\n");
            #endregion
            #region Primitives_C
            Console.ForegroundColor = ConsoleColor.Red;
            int x1 = 5;
            Object obj1 = x1;
            int y1 = (int)obj1;

            Object obj2 = x1;
            short y2 = (short)(int)obj2; // Unpacking and then type casting
            Console.WriteLine($"y1: {y1}, y2: {y2}");
            #endregion
            #region Primitives_D
            var name = "German";
            var age = 26;
            var isStudying = true;
            Console.WriteLine($"Тип name: {name.GetType()},\nТип age: {age.GetType()},\ntype isStudying: {isStudying.GetType()}\n");
            #endregion
            #region Primitives_E
            Console.ForegroundColor = ConsoleColor.Cyan;
            int? x2 = 7;
            int? x3 = null;
            Console.WriteLine(x2.Value);
            Console.WriteLine(x2.HasValue);
            Console.WriteLine(x3.HasValue);
            #endregion
            #region Primitives_F
            var f = 100;
            //f = "string";  ошибка- неявное преобразование невозможно
            #endregion
            #endregion
            #region Strings
            #region Strings_A
            Console.ForegroundColor = ConsoleColor.Magenta;
            string[] strings = { "1111", "1112", "1113" };
            bool1 = Equals(strings[0], strings[1]);
            Console.WriteLine($"\nstr1 == str2 - {bool1}");
            int int3 = String.Compare(strings[0], strings[1]);
            Console.WriteLine(int3);
            #endregion
            #region Strings_B
            Console.WriteLine(strings[0] + strings[1] + strings[2]);
            string strA = string.Concat(strings);
            string strB = ((string)strA.Clone()).Substring(4, 7);
            Console.WriteLine(strB);
            char[] separators = new char[] { '2', '3' };
            string[] strings2 = strA.Split(separators, 3);
            Console.WriteLine(strings2[1]);
            strA = strA.Insert(3, "999");
            Console.WriteLine(strA);
            strA = strA.Remove(3, 3);
            Console.WriteLine(strA);
            string strP = $"My name is {MyName1.FirstName}, my subname is {MyName2.LastName}"; //string interpolation
            Console.WriteLine(strP);

            #endregion
            #region Strings_C
            strA = "";
            strB = null;

            Console.WriteLine(string.IsNullOrEmpty(strA));
            Console.WriteLine(string.IsNullOrEmpty(strB));
            #endregion
            #region Strings_D
            Console.ForegroundColor = ConsoleColor.White;
            StringBuilder strBuilder = new StringBuilder("Abc", 50);
            strBuilder.Append(new char[] { 'D', 'e', 'f' });
            Console.WriteLine(strBuilder);
            strBuilder.AppendFormat("Ghi{0}{0}{1}", 'J', 'k');
            Console.WriteLine(strBuilder);
            strBuilder.Replace("Def", "123");
            Console.WriteLine(strBuilder);
            strBuilder.Remove(3, 9);
            Console.WriteLine(strBuilder);
            #endregion
            #endregion
            #region Massives
            #region Massives_A
            int[,] matrix1 = new int[3, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };
            int rows = matrix1.GetUpperBound(0) + 1;            //GetUpperBound = GetLength - 1  || 3 + 1
            int columns = matrix1.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix1[i, j]} \t");
                }
                Console.WriteLine();
            }
            #endregion
            #region Massives_B
            string[] WeekDays = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (string Day in WeekDays)
            {
                Console.Write($"{Day} \t");
            }
            Console.WriteLine($"\n{WeekDays.Length}");
            Console.WriteLine($"{WeekDays.GetLength(0)}");
            #endregion
            #region Massives_C
            int[][] arrayOfArrays = new int[3][];
            arrayOfArrays[0] = new int[2] { 0, 1 };
            arrayOfArrays[1] = new int[3] { 2, 3, 4 };
            arrayOfArrays[2] = new int[4] { 5, 6, 7, 8 };
            foreach (int[] row in arrayOfArrays)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.Write("\n");
            }

            #endregion
            #region Massives_D
            var someArray = arrayOfArrays;
            var someString = strP;
            Console.WriteLine($"Тип переменной someArray: {someArray.GetType()}");
            Console.WriteLine($"Тип переменной someString: {someString.GetType()}");
            #endregion
            #endregion
            #region Tuples
            #region Tuples_A/B
            Console.ForegroundColor = ConsoleColor.Blue;
            (int, string, char, string, ulong) tuple1 = (a: 4, string1: "Sample", symbol: 'a', string2: "Sample2", Item5: 1000000);

            Console.WriteLine(tuple1);
            Console.WriteLine($"tuple1: 1- {tuple1.Item1}, 4 - {tuple1.Item4}, 5 - {tuple1.Item5}");
            #endregion
            #region Tuples_C
            var tuple2 = new Tuple<string, int, string, int, char, int, float>("New York", 7781984, "London", 78, 'c', 74, 321.3f);
            Console.WriteLine(tuple2);
            ShowValue(69);
            #endregion
            #region Tuples_D
            (int, string, char, string, ulong) tuple3 = (a: 4, string1: "Sample", symbol: 'a', string2: "Sample2", Item5: 1000000);
            if (tuple1.Equals(tuple3))
            {
                Console.WriteLine("Кортежи равны!");
            }
            #endregion
            #region Task_5
            (int, int, char) my_func(int[] arrayOfInt, string strTest)
            {
                (int, int, char) tuple4 = (arrayOfInt.Min(), arrayOfInt.Max(), strTest.First());
                return tuple4;
            }
            Console.WriteLine(my_func(arrayOfArrays[2], strP));
            #endregion
            #region Task_6
            int multiplication(int i, int k)
            {
                checked {
                    int max = int.MaxValue;
                    return max;
                }
                return i * k;
            }
            int mult(int i, int k)
            {
                unchecked
                {
                    int max_2 = int.MaxValue;
                    return i * k / max_2;
                }
                return i * k;
            }
            Console.WriteLine(checked(multiplication(4, 3)));
            Console.WriteLine(checked(mult(3, 3)));

            #endregion
            #endregion

        }
    }
}

