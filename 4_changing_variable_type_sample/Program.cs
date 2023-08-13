Console.Write("kisa kenar: ");
int kisa= int.Parse(Console.ReadLine());

Console.Write("uzun kenar: ");
int uzun= int.Parse(Console.ReadLine());

// int alan = (kisa * uzun);
var alan = (kisa * uzun);


int cevre= (kisa+ uzun)*2;

// var str= "Samet Candan";

// var price= 100.5;

// Console.WriteLine("alan: "+ alan + " "+ "çevre: "+ cevre );
System.Console.WriteLine($"alan: {alan}  çevre: {cevre} ");