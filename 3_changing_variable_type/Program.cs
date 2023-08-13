//implicit casting: smaller type to larger
int a = 10;

long b= a;

float e = 10.5f;
double f = e;

//explicit casting : larger type to smaller

long c = 10;
int d = (int)c;

double g = 10.6;
float h=(float)g;

double k = 10.5;
int  l=(int)k;

int m= 23654;
byte n= (byte)m;

//int to string
int x = 10;
string z= x.ToString();

System.Console.WriteLine(n);

// Console.Write("1.sayi: ");
// int sayi1= int.Parse(Console.ReadLine()) ;

// Console.Write("2.sayi: ");
// int sayi2= int.Parse(Console.ReadLine());

// int toplam = sayi1+sayi2;

// Console.WriteLine($"girilen toplam değer: {toplam}");