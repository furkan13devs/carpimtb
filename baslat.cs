for (int j = 1; j <= 10; j++) // her sayımızı 1'den 10'a kadar çarptırma yaptığı kısım
                {
                    for (int i = 1; i <= 5; i++) // hangi sayıları 1'den 10'a kadar çarpacağı kısım burayı 5 yaptık ve en son değerimiz 50 oldu bu kısmı 10 yapsak 10 çarpı 10'dan 100 yapacak idi.
                    {
                        Console.Write("{0}*{1}={2}\t", i, j, (i * j)); // ekran çıktısı aldığımız kısım 
                    }
                    Console.WriteLine(); // alt alta sıralasın diye boşlukları atadığımız kısım
                }
                Console.ReadKey();
