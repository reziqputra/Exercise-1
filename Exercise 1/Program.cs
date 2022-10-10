namespace Exercise1_146
{

    class Program
    {
        private int[] reziq = new int[66];

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
                reziq[i] = Int32.Parse(s1);
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
                Console.WriteLine(reziq[RP]);
            }
            Console.WriteLine("");
        }
        public void InsertSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                for(int RP = 0; RP < n - i; RP++)
                {
                    if(reziq[RP] > reziq[RP + 1])
                    {
                        int temp;
                        temp = reziq[RP];
                        reziq[RP] = reziq[RP + 1];
                        reziq[RP + 1] = temp;
                    }
                }
            }
        }
        static void Main (string[] args)
        {
            Program myList = new Program();
            myList.read();
            myList.InsertSortArray();
            myList.display();
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk keluar.");
            Console.Read();
        }
    }
}