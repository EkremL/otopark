using System;


    class Vehicles
    {
        public int sayac1 = 0;
        public int sayac2 = 0;
        public int sayac3 = 0;
        public string dizgi;
        public int normalPark = 15;
        public int miniPark = 5;
        public int i;
     
        public void Dizgi()
        {
            dizgi = Console.ReadLine();
            
            

            if (dizgi.Length == 0)
            {
                Console.WriteLine("HATA ! Lütfen arac giriniz");
            }

            else
            {
                Console.WriteLine("Toplam Araç Sayisi: " + dizgi.Length);

                for (i = 0; i < dizgi.Length; i++)
                {
                    if (dizgi[i] == 'A')
                    {
                        sayac1++;
                    }

                }
                Console.WriteLine("Dizgideki araba sayisi:" + sayac1);


                for (i = 0; i < dizgi.Length; i++)
                {
                    if (dizgi[i] == 'K')
                    {
                        sayac2++;
                    }

                }
                Console.WriteLine("Dizgideki kamyon sayisi:" + sayac2);


                for (i = 0; i < dizgi.Length; i++)
                {
                    if (dizgi[i] == 'M')
                    {
                        sayac3++;
                    }

                }
                Console.WriteLine("Dizgideki motor sayisi:" + sayac3);
            }

        }
        public void Kontrol()
        {   
            
            int cnt;
            cnt = sayac1;
          

            Console.WriteLine("Giren araba sayisi:" + cnt + "\t" + normalPark);


        }

    }
    class program
    {
        static void Main(string[] args)
        {
            Vehicles ob = new Vehicles();
            Console.WriteLine("Parking App");
            Console.Write("Girecek aracların dizgisini giriniz:");
            ob.Dizgi();   
         
            ob.Kontrol();

            Console.WriteLine();



            Console.ReadKey();



        }


    }

