for (int j = 1; j <= 10; j++) // her sayımızı 1'den 10'a kadar çarptırma yaptığı kısım
                {
                    for (int i = 1; i <= 5; i++) 
                    {
                        Console.Write("{0}*{1}={2}\t", i, j, (i * j)); 
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
