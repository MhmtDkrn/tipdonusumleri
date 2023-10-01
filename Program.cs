
//Atama ve işlemli atamalar
int x=5;
int y=4;
y+=3;
Console.WriteLine(y);
y/=1;
Console.WriteLine(y);
x-=3;
Console.WriteLine(x);

//Mantıksal Operatörler (&&, ||, !)
bool isSuccess = true;
bool isCompleted = false;

if (isSuccess && isCompleted)
    Console.WriteLine("Perfect!");
if (isSuccess || isCompleted)
    Console.WriteLine("Awesome!");
if (isSuccess != isCompleted)
    Console.WriteLine("Fine!");
else 
    Console.WriteLine("Finally");