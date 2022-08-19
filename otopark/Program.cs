using System;


    class Vehicles
    {
        public int sayac1 = 0;
        public int sayac2 = 0;
        public int sayac3 = 0;
        public string dizgi;
        public static int normalPark;
        public static int miniPark;
        public int i;
        public int cnt = 1;
        public int cntt = 1;
        public int cnttt = 1;
        public int cntttt = 1;

    public void Veriler()
    {
        Console.Write("Normal park alanini giriniz:");
        normalPark = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Mini park alanini giriniz:");
        miniPark = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("ARACLARI GIRINIZ:");
        dizgi = Console.ReadLine();
        Console.WriteLine("ARAC DİZİSİ:" + dizgi);

    }
    public void Dizgi()
        {

        

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
        

        foreach  (char x in dizgi)
        {
            if (normalPark != 0 && x == 'A')
            {

              
                if (normalPark > 0)
                {
                    Console.WriteLine("" + cnt + ".ci araba girdi.");
                    cnt++;
                    normalPark -= 1;
                    if (normalPark == 0)
                    {
                        Console.WriteLine("Yer kalmadi");
                        
                    }
                }


            }
            else if (normalPark != 0 && x == 'K')
            {

                
                if (normalPark > 0)
                {
                    Console.WriteLine("" + cntt + ".ci kamyon girdi.");
                    cntt++;
                    normalPark -= 3;
                    if (normalPark == 0 )
                    {
                        Console.WriteLine("Yer kalmadi");
                        
                    }
                    if (normalPark == 1)
                    {
                        normalPark--;
                        Console.WriteLine("Yer kalmadi");

                    }
                    if (normalPark == 2)
                    {
                        normalPark -= 2;
                        Console.WriteLine("Yer kalmadi");

                    }
                }


            }
            else if (miniPark != 0 && normalPark != 0 && x == 'M')
            {

                
                if (miniPark > 0)
                {
                    Console.WriteLine("" + cntttt + ".ci motor girdi.");
                    cntttt++;
                    miniPark -= 1;
                    if (miniPark == 0)
                    {
                        Console.WriteLine("Miniparkta yer kalmadi");
   
                    }

                    
                }
            }
            else if (miniPark == 0 && normalPark > 0)
            {
                Console.WriteLine("" + (cntttt + (cnttt - 1)) + ".ci motor girdi.");
                cnttt++;
                normalPark -= 1;
                if (normalPark == 0)
                {
                    Console.WriteLine("Yer kalmadi");

                }
            }

        }
   

    }
    public void Girdi_giremedi()
    {
        Console.WriteLine("Dizgideki " + sayac1 + " adet arabadan " + (cnt - 1) + " tanesi girebildi , " + (sayac1 - cnt + 1) + " tanesi giremedi.");
        Console.WriteLine("Dizgideki " + sayac2 + " adet kamyondan " + (cntt - 1) + " tanesi girebildi , " + (sayac2 - cntt + 1) + " tanesi giremedi.");
        Console.WriteLine("Dizgideki " + sayac3 + " adet motordan " + (cntttt - 1) + " tanesi miniparka girebildi , " + (cnttt - 1) + " tanesi normal parka girdi ," + (sayac3 - (cnttt + cntttt) + 2) + " tanesi giremedi.");
    }
}
    class program
    {
        static void Main(string[] args)
        {
            Vehicles ob = new Vehicles();
            
            Console.WriteLine("PARKING APP");


            ob.Veriler();
            ob.Dizgi();
            Console.WriteLine("Hangi araclar girebilir hesaplaniyor..");
            ob.Kontrol();
            ob.Girdi_giremedi();
            Console.ReadKey();
        }

    }

