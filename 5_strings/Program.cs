
Console.Write("Name: ");
string name =Console.ReadLine();
Console.Write("Surname: ");
string surname =Console.ReadLine();


Console.Write("Age: ");
int age = int.Parse(Console.ReadLine());


// string str= "My name is "+ name+ " " +surname+ "and I'm " + age+ " years old.";
// string str= $"My name is {name} {surname} and I'm {age} years old.";
string str = string.Format("My name is {0} {1} and I'm {2} years old", name, surname, age);

System.Console.WriteLine(str);
