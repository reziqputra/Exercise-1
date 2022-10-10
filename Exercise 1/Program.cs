namespace Exercise1_146 //create namespace
{

    class Program //create
    {
        //deklarasi array int dengan ukuran 66
        private int[] reziq = new int[66];

        // deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //fungsi /method untuk menerima masukan
        public void read()
        {
            // menerima angka untuk menentukan banyaknya data yang disimpan pada array
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

            // pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + ( i + 1) + ">");
                string s1 = Console.ReadLine();
                reziq[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //menampilkan array yang tersusun
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
                        //tukar elemen
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
            //membuat objek untuk kelas insertsort
            Program myList = new Program();

            // Pemanggilan fungsi untuk menerima elemen array
            myList.read();

            // pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.InsertSortArray();

            // pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();

            //exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk keluar.");
            Console.Read();
        }
    }
}