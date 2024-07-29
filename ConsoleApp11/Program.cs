//Geriye Değer Döndürmeyen Bir void metot.
using System.Runtime.InteropServices;

static void SarkiSozu()
{
    Console.WriteLine("Yaşamak dediğin oğlum, zor sanat.");
}
SarkiSozu();
Console.WriteLine("-----------------------");
// Geriye Tamsayı Döndüren Bir metot.
static int TamSayı()
{
    Random rnd = new Random();
    int randomNumber = rnd.Next();
    return randomNumber % 2;
}
Console.WriteLine(TamSayı());
Console.WriteLine("-----------------------");
//Parametre Alan ve Geriye Değer Döndüren Bir Metot
static int Carpim(int x, int y)
{
    return x * y;
}
Console.WriteLine(Carpim(8, 2));
Console.WriteLine("-----------------------");
//Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
static void AdSoyad(string ad, string soyad)
{
    Console.WriteLine($"Hoş geldiniz {ad} {soyad}");
}
string ad = "Atakan";
string soyad = "Çelik";
AdSoyad(ad, soyad);