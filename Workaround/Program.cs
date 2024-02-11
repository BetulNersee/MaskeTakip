

// Degiskenler();

using Entities.Concrete;
using Business.Concrete;

Vatandas vatandas1 = new Vatandas();

SelamVer(isim: "Betül");
SelamVer(isim: "Engin");
SelamVer(isim: "Seher");
SelamVer();


int sonuc = Topla(6, 58);

// Diziler / Arrays

string ogrenci1 = "Betül";
string ogrenci2 = "Seher";
string ogrenci3 = "İlknur";

string[] ogrenciler = new string[3];
ogrenciler[0] = "Betül";
ogrenciler[1] = "Seher";
ogrenciler[2] = "ilknur";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Iğdır,Van,Kars" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);


Person person1 = new Person();
person1.FirstName = "BETÜL";
person1.LastName = "Nerse";
person1.DateOfBirthYear = 1996;
person1.NationalIdenity = 123;

Person person2 = new Person();
person2.FirstName = "Seher";

foreach (string sehir in sehirler1)
{

    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> {"Adana1","Ankara1","İstanbul1"};
yeniSehirler1.Add(item: "İzmir1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);

}

   PttManager pttManager = new PttManager ( new PersonManager());
   pttManager.GiveMask(person1);


Console.ReadLine();

// resharper
static void SelamVer(string isim = "noname")
{

    Console.WriteLine("Merhaba" + isim);
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc.ToString());
    return sonuc;
}

//static void Degiskenler()
//{
//    string mesaj = "merhaba";
//    double tutar = 100000; // database'den gelir.
//    int sayi = 100;
//    bool girisYapmisMi = false;


//    string ad = "Betül";
//    string soyad = "N.";
//    int dogumYili = "1996";
//    long tcNo = "12345678910";


//    Console.WriteLine(mesaj);


//    Console.WriteLine(tutar * 1.18);
// } 
//pascal casing
public class Vatandas
{
    public string Ad { get; set; }

    public string Soyad { get; set; }

    public int DogumYili { get; set; }

    public long TcNo { get; set; }
}