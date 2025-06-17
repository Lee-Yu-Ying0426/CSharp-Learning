// See https://aka.ms/new-console-template for more information

//使用 for 迴圈印出九九乘法表（1～9 的乘法組合）。

Console.WriteLine("=====九九乘法表(矩形)=====");
for(int i = 1; i < 10; i++)
{
    for(int j = 1; j < 10; j++)
    {
        int product = i * j;
        string a = "";
        if (product / 10 == 0) a = "0";
        Console.Write($"{i} * {j} = {a}{product}　");
    }
    Console.WriteLine("");
}

Console.WriteLine("=====九九乘法表(矩形2)=====");
for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        int product = i * j;
        string a = "" ;
        if (product / 10 == 0)  a = "0";
        Console.Write($"{j} * {i} = {a}{product}　");
    }
    Console.WriteLine("");
}

Console.WriteLine("=====九九乘法表(三角形)=====");
for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < i+1; j++)
    {
        int product = i * j;
        string a = "";
        if (product / 10 == 0) a = "0";
        Console.Write($"{j} * {i} = {a}{product}　");
    }
    Console.WriteLine("");
}

Console.WriteLine("=====九九乘法表(倒三角形)=====");
for (int i = 1; i < 10; i++)
{
    for ( int j = 1; j <= 10- i ; j++)
    {
        int product = i * j;
        string a = "";
        if (product / 10 == 0) a = "0";
        Console.Write($"{j} * {i} = {a}{product}　");
    }
    Console.WriteLine("");
}
