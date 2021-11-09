//Виды функций

//1 вид (void метод)
//Ничего не принимает,
//Ничего не возвращает

//2 вид (void метод)
//Что-то принимает
//Ничего не возвращает

//3 вид (например, генерирует случайные данные)
//Ничего не принимает
//Что-то возвращает

//4 вид
//Что-то принимает
//Что-то возвращает



//11. Показать вторую цифру трёхзначного числа
//Сперва показать десятки. 
//12. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

//13. Удалить вторую цифру трёхзначного числа

//14.Выяснить, кратно ли число заданному, если нет, вывести остаток. 

//15.Найти третью цифру числа или сообщить, что её нет*

//12. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
//Алгоритм:
/* int x = 10;
int y = 99;
int z = new Random().Next(x,y+1);

System.Console.WriteLine($"Число из отрезка {z}");
int PrintNumber(int z)
{
    int n = z/10;
    int m = z%10;
    if (n>m) 
    {
        return n;
    }
    else
    {
        return m;
    }
}
System.Console.Write("Наибольшая цифра числа = ");
Console.WriteLine(PrintNumber(z)); */

//13. Удалить вторую цифру трёхзначного числа
/* int number = 423;
int DelNum(int number)
    {
        int z=number/100;
        int m=number%10;
        int result = (z*10)+m;
        return result;
    }
System.Console.Write(DelNum(number)); */

//14.Выяснить, кратно ли число заданному, если нет, вывести остаток. 

int a = 110;
int b = 60;

string Method1(int a, int b)
{
    string text = string.Empty;

    if (a > b)
    {
        if (a % b == 0)
        {
            text = "кратно";
        }
        else
        {
            int c = a % b;
            text = $"{c}";
        }
    }
    else
    {
        text = "неверно заданы числа";
    }
    return text;

}
System.Console.WriteLine(Method1(a, b));



/* 
    void Method1(int a, int b)
    {
        if (a>b)
        {
            if (a%b == 0)
            {   
            System.Console.WriteLine("кратно");
            }
            else
            {
            int c = a%b;
            System.Console.WriteLine(c);
            }
        }
        else
        {
             System.Console.WriteLine("неверно заданы числа");
        }
    }
    Method1(a,b); */

/*   int Method1(int a, int b)
  {
  if (a%b == 0)
  {   int result = ;
      return  result;

  } */

//15.Найти третью цифру числа или сообщить, что её нет*
/* int i = 1254;
if (i > 100 &&

    {

}
else
{

} */

