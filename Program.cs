// See https://aka.ms/new-console-template for more information
// atama ve işlem yapma
using System;

namespace operatorler
{
    internal class NewBaseType
    {
        static void Main(string[] args)
       {
int x=3;
int y=2;
y= y+2;

Console.WriteLine(y);
y += 2;
Console.WriteLine(y);
y /= 1;
Console.WriteLine(y);
x *=2;

bool isSourcess = true;
bool isComleted = false;

if(isSourcess && isComleted)
Console.WriteLine("Harika");

if(isSourcess || isComleted)
Console.WriteLine("Great");

// ilişkisel operatorler

int a= 3;
int b= 4;
bool Sonuc = a<b;

Console.WriteLine(Sonuc);

Sonuc= a>b;
Console.WriteLine(Sonuc);
Sonuc= a==b;
Console.WriteLine(Sonuc);
Sonuc= a<=b;
Console.WriteLine(Sonuc);
Sonuc= a>=b;

// aritmetik opretatorler

int sayi1= 14;
int sayi2= 5;
int sonuc1= sayi1+sayi2;
Console.WriteLine(sonuc1);
            int v = sayi1 + sayi2;
            sonuc1 = v;
Console.WriteLine(sonuc1);
sonuc1= sayi1-sayi2;
Console.WriteLine(sonuc1);
sonuc1= sayi1++;
Console.WriteLine(sonuc1);
       }
       }
       }