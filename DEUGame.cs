using System;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp, temp0, temp1, temp2, temp3, temp4, temp5, temp6, temp7, temp8, temp9, temp10;//names dizisi için değişken değiştirmeye yardımcı
            int temps, temp0s, temp1s, temp2s, temp3s, temp4s, temp5s, temp6s, temp7s, temp8s, temp9s, temp10s;//scores dizisi için değişken değiştirmeye yardımcı
            bool Control = false; int r; int scorep1 = 120; int scorep2 = 120; int score; string player;

            string[] names = { "Derya  ", "Elife  ", "Fatih  ", "Ali    ", "Azra   ", "Sibel  ", "Cem    ", "Nazan  ", "Mehmet ", "Nil    ", "Can    ", "Tarkan ", " " };
            int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30, 0 };


            Random rnd = new Random();
            string[] A1 = new string[15];
            string[] A2 = new string[15];
            string[] A3 = new string[15];
            string[] array = new string[] { "A1", "A2", "A3" };//rastgele seçeceği array için.
            string[] letter = new string[] { "D ", "E ", "U " };// rastgele seçeceği harf için.

            for (r = 0; r < 46; r++)//r=44 iken tüm diziler yazılmıştır.r=45 olursa döngüden çıkılmamıştır öyleyse beraberlik söz konusu
            {
                int AA = rnd.Next(array.Length);
                int i = rnd.Next(letter.Length);

                if (AA == 0)//rastgele seçim A1
                {
                    if (r == 45)//beraberlik durumunda skor tablosu ve tie
                    {
                        Console.WriteLine("\n\n Tie");
                        Console.WriteLine("\nName              Score");
                        Console.WriteLine(" ");

                        for (int m = 0; m < 12; m++)
                            Console.WriteLine(names[m] + "           " + scores[m]);

                    }
                    else
                    {
                        if ((A1[14] == "D ") || (A1[14] == "E ") || (A1[14] == "U "))//eğer dizinin tamamı yazıldıysa diğer dizileri yazdırması için
                        {
                            r--;

                        }
                        else
                        {
                            for (int s = 0; s < 15; s++)
                            {
                                if ((A1[s] != "D ") && (A1[s] != "E ") && (A1[s] != "U "))//array i  boşluksuz sırayla yazdırmak için 
                                {
                                    A1[s] = letter[i];
                                    break;
                                }
                            }

                            if (r % 2 == 0)// r çift sayıyken 1.oyuncu oynar ve onun skoru 5 eksiltilir ;tek sayıyken 2. oyuncu oynar ve onun skoru 5 eksiltilir.
                            {
                                scorep1 -= 5;
                                player = "Player1";
                            }
                            else
                            {
                                scorep2 -= 5;
                                player = "Player2";
                            }

                            Console.WriteLine(player + ":  (P1 - " + scorep1 + " P2 - " + scorep2 + ")");
                            Console.Write("A1 ");
                            for (int x1 = 0; x1 < A1.Length; x1++)
                                Console.Write(A1[x1]);
                            Console.Write("\nA2 ");
                            for (int x1 = 0; x1 < A2.Length; x1++)
                                Console.Write(A2[x1]);
                            Console.Write("\nA3 ");
                            for (int x1 = 0; x1 < A3.Length; x1++)
                                Console.Write(A3[x1]);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");


                            //DEU yazım kontrolleri
                            for (int n = 0; n < 15; n++)//deu yazısının düşey yazımını kontrol eder 
                            {
                                if ((A1[n] == "D ") && (A2[n] == "E ") && (A3[n] == "U "))//yukarıdan aşağıya düz
                                {
                                    Control = true;
                                    if (r % 2 == 0)
                                        Console.WriteLine("\n\nwinner: Player1");
                                    else
                                        Console.WriteLine("\n\nwinner: Player2");
                                    break;
                                }
                                else if ((A1[n] == "U ") && (A2[n] == "E ") && (A3[n] == "D "))//yukarıdan aşağıya ters
                                {
                                    Control = true;
                                    if (r % 2 == 0)
                                        Console.WriteLine("\n\nwinner: Player1");
                                    else
                                        Console.WriteLine("\n\nwinner: Player2");
                                    break;
                                }

                            }
                            if (Control == false)//bir harfin iki farklı  şekilde deu yazdırması durumunda iki kez winner yazma olasılığını sıfırlamak için
                            {
                                for (int n = 0; n < 13; n++)//deu yazısının yatay ve çapraz yazımını kontrol eder n+2 en fazla 14 olacağından döngü n < 13 e kadar
                                {
                                    if ((A1[n] == "D ") && (A2[n + 1] == "E ") && (A3[n + 2] == "U "))// güneydoğu çapraz düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A1[n] == "U ") && (A2[n + 1] == "E ") && (A3[n + 2] == "D "))// kuzeybatı çapraz ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A3[n] == "D ") && (A2[n + 1] == "E ") && (A1[n + 2] == "U "))// kuzeydoğu çapraz ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A3[n] == "U ") && (A2[n + 1] == "E ") && (A1[n + 2] == "D "))// güneybatı çapraz düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A1[n] == "D ") && (A1[n + 1] == "E ") && (A1[n + 2] == "U "))//a1 için yatay düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A1[n] == "U ") && (A1[n + 1] == "E ") && (A1[n + 2] == "D "))//a1 için yatay ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A2[n] == "D ") && (A2[n + 1] == "E ") && (A2[n + 2] == "U "))//a2 için yatay düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A2[n] == "U ") && (A2[n + 1] == "E ") && (A2[n + 2] == "D "))//a2 için yatay ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A3[n] == "D ") && (A3[n + 1] == "E ") && (A3[n + 2] == "U "))//a3 için yatay düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A3[n] == "U ") && (A3[n + 1] == "E ") && (A3[n + 2] == "D "))//a3 için yatay ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                if (AA == 1)//rastgele seçim A2
                {
                    if (r == 45)//beraberlik durumunda skor tablosu ve tie
                    {
                        Console.WriteLine("\n\n Tie");
                        Console.WriteLine("\nName              Score");
                        Console.WriteLine(" ");

                        for (int m = 0; m < 12; m++)
                            Console.WriteLine(names[m] + "           " + scores[m]);

                    }
                    else
                    {
                        if ((A2[14] == "D ") || (A2[14] == "E ") || (A2[14] == "U "))//eğer dizinin tamamı yazıldıysa diğer dizileri yazdırması için
                        {
                            r--;

                        }
                        else
                        {
                            for (int s = 0; s < 15; s++)
                            {
                                if ((A2[s] != "D ") && (A2[s] != "E ") && (A2[s] != "U "))
                                {
                                    A2[s] = letter[i];
                                    break;
                                }
                            }

                            if (r % 2 == 0)
                            {
                                scorep1 -= 5;
                                player = "Player1";
                            }
                            else
                            {
                                scorep2 -= 5;
                                player = "Player2";
                            }

                            Console.WriteLine(player + ":  (P1 - " + scorep1 + " P2 - " + scorep2 + ")");
                            Console.Write("A1 ");
                            for (int x1 = 0; x1 < A1.Length; x1++)
                                Console.Write(A1[x1]);
                            Console.Write("\nA2 ");
                            for (int x1 = 0; x1 < A2.Length; x1++)
                                Console.Write(A2[x1]);
                            Console.Write("\nA3 ");
                            for (int x1 = 0; x1 < A3.Length; x1++)
                                Console.Write(A3[x1]);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");


                            //DEU yazım kontrolleri
                            for (int n = 0; n < 15; n++)//deu yazısının düşey yazımını kontrol eder 
                            {
                                if ((A1[n] == "D ") && (A2[n] == "E ") && (A3[n] == "U "))//yukarıdan aşağıya düz
                                {
                                    Control = true;
                                    if (r % 2 == 0)
                                        Console.WriteLine("\n\nwinner: Player1");
                                    else
                                        Console.WriteLine("\n\nwinner: Player2");
                                    break;
                                }
                                else if ((A1[n] == "U ") && (A2[n] == "E ") && (A3[n] == "D "))//yukarıdan aşağıya ters
                                {
                                    Control = true;
                                    if (r % 2 == 0)
                                        Console.WriteLine("\n\nwinner: Player1");
                                    else
                                        Console.WriteLine("\n\nwinner: Player2");
                                    break;
                                }

                            }
                            if (Control == false)//bir harfin iki farklı  şekilde deu yazdırması durumunda iki kez winner yazma olasılığını sıfırlamak için
                            {
                                for (int n = 0; n < 13; n++)//deu yazısının yatay ve çapraz yazımını kontrol eder n+2 en fazla 14 olacağından döngü n < 13 e kadar
                                {
                                    if ((A1[n] == "D ") && (A2[n + 1] == "E ") && (A3[n + 2] == "U "))// güneydoğu çapraz düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A1[n] == "U ") && (A2[n + 1] == "E ") && (A3[n + 2] == "D "))// kuzeybatı çapraz ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A3[n] == "D ") && (A2[n + 1] == "E ") && (A1[n + 2] == "U "))// kuzeydoğu çapraz ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A3[n] == "U ") && (A2[n + 1] == "E ") && (A1[n + 2] == "D "))// güneybatı çapraz düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A1[n] == "D ") && (A1[n + 1] == "E ") && (A1[n + 2] == "U "))//a1 için yatay düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A1[n] == "U ") && (A1[n + 1] == "E ") && (A1[n + 2] == "D "))//a1 için yatay ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A2[n] == "D ") && (A2[n + 1] == "E ") && (A2[n + 2] == "U "))//a2 için yatay düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A2[n] == "U ") && (A2[n + 1] == "E ") && (A2[n + 2] == "D "))//a2 için yatay ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A3[n] == "D ") && (A3[n + 1] == "E ") && (A3[n + 2] == "U "))//a3 için yatay düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A3[n] == "U ") && (A3[n + 1] == "E ") && (A3[n + 2] == "D "))//a3 için yatay ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                if (AA == 2)//rastgele seçim A3
                {
                    if (r == 45)
                    {
                        Console.WriteLine("\n\n Tie");
                        Console.WriteLine("\nName              Score");
                        Console.WriteLine(" ");

                        for (int m = 0; m < 12; m++)
                            Console.WriteLine(names[m] + "           " + scores[m]);

                    }
                    else
                    {
                        if ((A3[14] == "D ") || (A3[14] == "E ") || (A3[14] == "U "))
                        {
                            r--;

                        }
                        else
                        {
                            for (int s = 0; s < 15; s++)
                            {
                                if ((A3[s] != "D ") && (A3[s] != "E ") && (A3[s] != "U "))
                                {
                                    A3[s] = letter[i];
                                    break;
                                }
                            }

                            if (r % 2 == 0)
                            {
                                scorep1 -= 5;
                                player = "Player1";
                            }
                            else
                            {
                                scorep2 -= 5;
                                player = "Player2";
                            }

                            Console.WriteLine(player + ":  (P1 - " + scorep1 + " P2 - " + scorep2 + ")");
                            Console.Write("A1 ");
                            for (int x1 = 0; x1 < A1.Length; x1++)
                                Console.Write(A1[x1]);
                            Console.Write("\nA2 ");
                            for (int x1 = 0; x1 < A2.Length; x1++)
                                Console.Write(A2[x1]);
                            Console.Write("\nA3 ");
                            for (int x1 = 0; x1 < A3.Length; x1++)
                                Console.Write(A3[x1]);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");



                            //DEU yazım kontrolleri
                            for (int n = 0; n < 15; n++)//deu yazısının düşey yazımını kontrol eder 
                            {
                                if ((A1[n] == "D ") && (A2[n] == "E ") && (A3[n] == "U "))//yukarıdan aşağıya düz
                                {
                                    Control = true;
                                    if (r % 2 == 0)
                                        Console.WriteLine("\n\nwinner: Player1");
                                    else
                                        Console.WriteLine("\n\nwinner: Player2");
                                    break;
                                }
                                else if ((A1[n] == "U ") && (A2[n] == "E ") && (A3[n] == "D "))//yukarıdan aşağıya ters
                                {
                                    Control = true;
                                    if (r % 2 == 0)
                                        Console.WriteLine("\n\nwinner: Player1");
                                    else
                                        Console.WriteLine("\n\nwinner: Player2");
                                    break;
                                }

                            }
                            if (Control == false)//bir harfin iki farklı  şekilde deu yazdırması durumunda iki kez winner yazma olasılığını sıfırlamak için
                            {
                                for (int n = 0; n < 13; n++)//deu yazısının yatay ve çapraz yazımını kontrol eder n+2 en fazla 14 olacağından döngü n < 13 e kadar
                                {
                                    if ((A1[n] == "D ") && (A2[n + 1] == "E ") && (A3[n + 2] == "U "))// güneydoğu çapraz düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A1[n] == "U ") && (A2[n + 1] == "E ") && (A3[n + 2] == "D "))// kuzeybatı çapraz ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A3[n] == "D ") && (A2[n + 1] == "E ") && (A1[n + 2] == "U "))// kuzeydoğu çapraz ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A3[n] == "U ") && (A2[n + 1] == "E ") && (A1[n + 2] == "D "))// güneybatı çapraz düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A1[n] == "D ") && (A1[n + 1] == "E ") && (A1[n + 2] == "U "))//a1 için yatay düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A1[n] == "U ") && (A1[n + 1] == "E ") && (A1[n + 2] == "D "))//a1 için yatay ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A2[n] == "D ") && (A2[n + 1] == "E ") && (A2[n + 2] == "U "))//a2 için yatay düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A2[n] == "U ") && (A2[n + 1] == "E ") && (A2[n + 2] == "D "))//a2 için yatay ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A3[n] == "D ") && (A3[n + 1] == "E ") && (A3[n + 2] == "U "))//a3 için yatay düz
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                    else if ((A3[n] == "U ") && (A3[n + 1] == "E ") && (A3[n + 2] == "D "))//a3 için yatay ters
                                    {
                                        Control = true;
                                        if (r % 2 == 0)
                                            Console.WriteLine("\n\nwinner: Player1");
                                        else
                                            Console.WriteLine("\n\nwinner: Player2");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }




                if (Control == true)//deu yazıldıysa döngüden çıkmak için
                    break;
            }


            if (r < 45)//r= 45 ise beraberlik söz konusu.r<45 durumunda player1 veya player2 skor tablosuna yazılır.
            {
                if (r % 2 == 0)//r çift ise player1 , scorep1; tek ise player1 , scorep1.
                {
                    score = scorep1;
                    player = "player1";
                }
                else
                {
                    score = scorep2;
                    player = "player2";
                }
                //player1 ya da player2 nin skorundan küçük olanlar dizide kendisinden  sonraki değere atanır.
                if (score > 100)
                {

                    temp = names[11];
                    names[12] = temp;
                    temp10 = names[10];
                    names[11] = temp10;
                    temp9 = names[9];
                    names[10] = temp9;
                    temp8 = names[8];
                    names[9] = temp8;
                    temp7 = names[7];
                    names[8] = temp7;
                    temp6 = names[6];
                    names[7] = temp6;
                    temp5 = names[5];
                    names[6] = temp5;
                    temp4 = names[4];
                    names[5] = temp4;
                    temp3 = names[3];
                    names[4] = temp3;
                    temp2 = names[2];
                    names[3] = temp2;
                    temp1 = names[1];
                    names[2] = temp1;
                    temp0 = names[0];
                    names[1] = temp0;
                    names[0] = player;

                    temps = scores[11];
                    scores[12] = temps;
                    temp10s = scores[10];
                    scores[11] = temp10s;
                    temp9s = scores[9];
                    scores[10] = temp9s;
                    temp8s = scores[8];
                    scores[9] = temp8s;
                    temp7s = scores[7];
                    scores[8] = temp7s;
                    temp6s = scores[6];
                    scores[7] = temp6s;
                    temp5s = scores[5];
                    scores[6] = temp5s;
                    temp4s = scores[4];
                    scores[5] = temp4s;
                    temp3s = scores[3];
                    scores[4] = temp3s;
                    temp2s = scores[2];
                    scores[3] = temp2s;
                    temp1s = scores[1];
                    scores[2] = temp1s;
                    temp0s = scores[0];
                    scores[1] = temp0s;
                    scores[0] = score;

                }
                else if (score == 100)
                {
                    temp = names[11];
                    names[12] = temp;
                    temp10 = names[10];
                    names[11] = temp10;
                    temp9 = names[9];
                    names[10] = temp9;
                    temp8 = names[8];
                    names[9] = temp8;
                    temp7 = names[7];
                    names[8] = temp7;
                    temp6 = names[6];
                    names[7] = temp6;
                    temp5 = names[5];
                    names[6] = temp5;
                    temp4 = names[4];
                    names[5] = temp4;
                    temp3 = names[3];
                    names[4] = temp3;
                    temp2 = names[2];
                    names[3] = temp2;
                    names[2] = player;

                    temps = scores[11];
                    scores[12] = temps;
                    temp10s = scores[10];
                    scores[11] = temp10s;
                    temp9s = scores[9];
                    scores[10] = temp9s;
                    temp8s = scores[8];
                    scores[9] = temp8s;
                    temp7s = scores[7];
                    scores[8] = temp7s;
                    temp6s = scores[6];
                    scores[7] = temp6s;
                    temp5s = scores[5];
                    scores[6] = temp5s;
                    temp4s = scores[4];
                    scores[5] = temp4s;
                    temp3s = scores[3];
                    scores[4] = temp3s;
                    temp2s = scores[2];
                    scores[3] = temp2s;
                    scores[2] = score;

                }
                else if (score == 95)
                {
                    temp = names[11];
                    names[12] = temp;
                    temp10 = names[10];
                    names[11] = temp10;
                    temp9 = names[9];
                    names[10] = temp9;
                    temp8 = names[8];
                    names[9] = temp8;
                    temp7 = names[7];
                    names[8] = temp7;
                    temp6 = names[6];
                    names[7] = temp6;
                    temp5 = names[5];
                    names[6] = temp5;
                    temp4 = names[4];
                    names[5] = temp4;
                    temp3 = names[3];
                    names[4] = temp3;
                    names[3] = player;

                    temps = scores[11];
                    scores[12] = temps;
                    temp10s = scores[10];
                    scores[11] = temp10s;
                    temp9s = scores[9];
                    scores[10] = temp9s;
                    temp8s = scores[8];
                    scores[9] = temp8s;
                    temp7s = scores[7];
                    scores[8] = temp7s;
                    temp6s = scores[6];
                    scores[7] = temp6s;
                    temp5s = scores[5];
                    scores[6] = temp5s;
                    temp4s = scores[4];
                    scores[5] = temp4s;
                    temp3s = scores[3];
                    scores[4] = temp3s;
                    scores[3] = score;

                }
                else if (score == 90)
                {
                    temp = names[11];
                    names[12] = temp;
                    temp10 = names[10];
                    names[11] = temp10;
                    temp9 = names[9];
                    names[10] = temp9;
                    temp8 = names[8];
                    names[9] = temp8;
                    temp7 = names[7];
                    names[8] = temp7;
                    temp6 = names[6];
                    names[7] = temp6;
                    temp5 = names[5];
                    names[6] = temp5;
                    temp4 = names[4];
                    names[5] = temp4;
                    names[4] = player;

                    temps = scores[11];
                    scores[12] = temps;
                    temp10s = scores[10];
                    scores[11] = temp10s;
                    temp9s = scores[9];
                    scores[10] = temp9s;
                    temp8s = scores[8];
                    scores[9] = temp8s;
                    temp7s = scores[7];
                    scores[8] = temp7s;
                    temp6s = scores[6];
                    scores[7] = temp6s;
                    temp5s = scores[5];
                    scores[6] = temp5s;
                    temp4s = scores[4];
                    scores[5] = temp4s;
                    scores[4] = score;

                }
                else if (score == 85)
                {
                    temp = names[11];
                    names[12] = temp;
                    temp10 = names[10];
                    names[11] = temp10;
                    temp9 = names[9];
                    names[10] = temp9;
                    temp8 = names[8];
                    names[9] = temp8;
                    temp7 = names[7];
                    names[8] = temp7;
                    temp6 = names[6];
                    names[7] = temp6;
                    temp5 = names[5];
                    names[6] = temp5;
                    names[5] = player;

                    temps = scores[11];
                    scores[12] = temps;
                    temp10s = scores[10];
                    scores[11] = temp10s;
                    temp9s = scores[9];
                    scores[10] = temp9s;
                    temp8s = scores[8];
                    scores[9] = temp8s;
                    temp7s = scores[7];
                    scores[8] = temp7s;
                    temp6s = scores[6];
                    scores[7] = temp6s;
                    temp5s = scores[5];
                    scores[6] = temp5s;
                    scores[5] = score;

                }
                else if ((score <= 80) && (score > 70))
                {
                    temp = names[11];
                    names[12] = temp;
                    temp10 = names[10];
                    names[11] = temp10;
                    temp9 = names[9];
                    names[10] = temp9;
                    temp8 = names[8];
                    names[9] = temp8;
                    temp7 = names[7];
                    names[8] = temp7;
                    names[7] = player;

                    temps = scores[11];
                    scores[12] = temps;
                    temp10s = scores[10];
                    scores[11] = temp10s;
                    temp9s = scores[9];
                    scores[10] = temp9s;
                    temp8s = scores[8];
                    scores[9] = temp8s;
                    temp7s = scores[7];
                    scores[8] = temp7s;
                    scores[7] = score;

                }
                else if ((score <= 70) && (score > 55))
                {
                    temp = names[11];
                    names[12] = temp;
                    temp10 = names[10];
                    names[11] = temp10;
                    temp9 = names[9];
                    names[10] = temp9;
                    temp8 = names[8];
                    names[9] = temp8; ;
                    names[8] = player;

                    temps = scores[11];
                    scores[12] = temps;
                    temp10s = scores[10];
                    scores[11] = temp10s;
                    temp9s = scores[9];
                    scores[10] = temp9s;
                    temp8s = scores[8];
                    scores[9] = temp8s;
                    scores[8] = score;

                }
                else if (score == 55)
                {
                    temp = names[11];
                    names[12] = temp;
                    temp10 = names[10];
                    names[11] = temp10;
                    temp9 = names[9];
                    names[10] = temp9;
                    names[9] = player;

                    temps = scores[11];
                    scores[12] = temps;
                    temp10s = scores[10];
                    scores[11] = temp10s;
                    temp9s = scores[9];
                    scores[10] = temp9s;
                    scores[9] = score;

                }
                else if ((score <= 50) && (score > 30))
                {
                    temp = names[11];
                    names[12] = temp;
                    temp10 = names[10];
                    names[11] = temp10;
                    names[10] = player;

                    temps = scores[11];
                    scores[12] = temps;
                    temp10s = scores[10];
                    scores[11] = temp10s;
                    scores[10] = score;

                }
                else if (score <= 30)
                {

                    names[12] = player;
                    scores[12] = score;

                }
                Console.WriteLine("\nName              Score");
                Console.WriteLine(" ");

                for (int m = 0; m < 13; m++)
                    Console.WriteLine(names[m] + "           " + scores[m]);




            }
        }
    }
}























