
string deneme = "Hello My Friend"; // değişkenimize string veriyoruz.
Console.WriteLine("Kelimemiz :" + deneme);



char karakter = 'e';
Console.WriteLine(karakter + " Harfi " + deneme.IndexOf(karakter) + " İndextedir. ");
/*  IndexOf içine yazılan char'ın hangi indexte yer aldığını geri döndürür.
    Küçük Büyük harf duyarlıdır.
    Eğer Kelimeyi bulamazsa -1 çıktısını ekrana yazdırır.
*/

Console.WriteLine("Kelimemizin İçinde Hello stringi yer alıyor mu ?");
Console.WriteLine("Cevap : " + deneme.Contains("Hello"));

/*
    Contains metodu içine yazılan stringin kullanılan string değişkeninde yer alıp almadığına bakar.
    Küçük Büyük Harf Duyarlıdır.
    Kelimeyi bulursa True , Kelimeyi bulamazsa False döndürür. 
*/


string deneme2 = "Evet simdi split metodunun kullanımını inceliyoruz.";
Console.WriteLine("Kelimemiz :" + deneme2);
string[] kelimeler = deneme2.Split(' ');

foreach (var kelime in kelimeler)
{
    Console.WriteLine(kelime);
}

/*
    Split metodu elimizdeki stringi istediğimiz karaktere göre parçalamamıza yarar.
    Örneğin yukarda yaptığım gibi ' ' boşluğa göre böldüğüm için kelimeleri ayırıyor ve
    kelimeler dizimize atıyor.
    - - -  Seçilen karakter metnin içinden kayboluyor eğer bir harfe göre yapılırsa metinden eksilerek
    metin bozuluyor. - - -
 
*/















Console.ReadKey();