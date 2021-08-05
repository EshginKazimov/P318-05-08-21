using System;

namespace InheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student e = new Student("Elnur", "Suleymanzade", 31, "P318", 90);
            ////Console.WriteLine(e.Name + " " + e.Surname);
            //Console.WriteLine(e.GetInfo());

            //Student f = new Student("Fagan", "Eyvazov", 24, "P318", 80);
            //Console.WriteLine(e.GetInfo());
            //Console.WriteLine(f.GetInfo());

            //Teacher kamran = new Teacher("Kamran", "Nabiyev", 27, 5000, 70);
            //Console.WriteLine(kamran.GetInfo());

            //Developer test = new Developer("Test", "Test", 100, "Backend", 250);
            //Console.WriteLine(test.GetInfo());

            #region Array sort

            int[] arr = { 7, 3, 2, 1, 5 };

            int[] result = Sort(arr);

            foreach (int item in result)
            {
                Console.Write(item);
            }

            #endregion
        }

        static int[] Sort(int[] array) 
        {
            //{7,3,2,1,5};
            int temp = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i]>array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
