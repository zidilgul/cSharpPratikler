Console.WriteLine("-o-o-o- Atama ve İşlemli Atama -o-o-o-");
// Atama ve İşlemli Atama:
// =, +=, -=, *=, /=

int x = 5;
int y = 3;

y = y+4;
Console.WriteLine(y);
y += 8;
Console.WriteLine(y);
y/=3;
Console.WriteLine(y);
x *= 6;
Console.WriteLine(x);

Console.WriteLine("-o-o-o- Mantiksal Operatörler -o-o-o-");
// Mantıksal Operatörler:
// || (veya), && (ve), ! (değilse/tersini alır.)

bool isSucces = true;
bool isCompleted = false;

if(isSucces && isCompleted)  // Çalıştırmadı, çünkü birisi "true" diğeri "false". İkisinin de "true" ya da ikisinin de "false" olması gerekir. 
Console.WriteLine ("Perfect!");

if(isSucces || isCompleted)
Console.WriteLine ("Great!");

if(isSucces && !isCompleted)
Console.WriteLine ("Fine!");

Console.WriteLine("-o-o-o- İlişkisel Operatörler -o-o-o-");
// İlişkisel Operatörler:
// ==, != (eşit değildir.), <, >, >=, <=

int a = 3;
int b = 5;
bool sonuc = a<b;

Console.WriteLine (sonuc);
sonuc = a>b;
Console.WriteLine (sonuc);
sonuc = a>=b;
Console.WriteLine (sonuc);
sonuc = a<=b;
Console.WriteLine (sonuc);
sonuc = a==b;
Console.WriteLine (sonuc);
sonuc = a!=b;
Console.WriteLine (sonuc);

Console.WriteLine("-o-o-o- Aritmetik Operatörler -o-o-o-");
// Aritmetik Operatörler:
// /, *, +, -

int sayi1 = 16;
int sayi2 = 4;

int sonuc1 = sayi1/sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1*sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1+sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1-sayi2;
Console.WriteLine(sonuc1);
sonuc1 = ++sayi1;
Console.WriteLine(sonuc1);

Console.WriteLine("-o-o-o- % mod (Aritmetik Operatör) -o-o-o-");
// Mod:
// %

int sonuc2 = 20%3;
Console.WriteLine(sonuc2);

// The End.