namespace Exercise1_146
{

    class Program
    {
        private int[] a = new int[66];

        private int n;

        public void read()
        {
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 66)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 66 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen Array ");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + ( i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Elemen Array yang telah tersusun ");
            Console.WriteLine("----------------------------------");
            for(int RP = 0; RP < n; RP++)
            {
                Console.WriteLine(a[RP]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray
    }
}