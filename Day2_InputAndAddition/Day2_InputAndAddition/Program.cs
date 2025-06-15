// See https://aka.ms/new-console-template for more information

//int.TryParse將數位的字串表示轉換為其相等的32位帶正負號的整數。 
while (true)
{
    Console.WriteLine("======計算機=======");

    Console.Write("請輸入第一個數字(或輸入q結束): ");
    string input1 = Console.ReadLine();
    if (input1 == "q") return;

    Console.Write("請輸入第二個數字(或輸入q結束): ");
    string input2 = Console.ReadLine();
    if (input2 == "q") return;

    bool is_Valid1 = double.TryParse(input1, out double num1);
    bool is_Valid2 = double.TryParse(input2, out double num2);

    if (!is_Valid1 || !is_Valid2)
    {
        Console.WriteLine("請輸入有效整數。");
        continue;
    }

    Console.Write("請輸入運算符號+-*/ : ");
    string? op = Console.ReadLine();

    if (string.IsNullOrEmpty(op))
    {
        Console.WriteLine("請輸入有效運算元。");
        continue;
    }

    double sum;
    switch (op)
    {
        case "+":
            sum = num1 + num2;
            Console.WriteLine($"結果是:{num1} + {num2} = {sum}");
            break;
        case "-":
            sum = num1 - num2;
            Console.WriteLine($"結果是:{num1} - {num2} = {sum}");
            break;
        case "*":
            sum = num1 * num2;
            Console.WriteLine($"結果是:{num1} * {num2} = {sum}");
            break;
        case "/":
            if(num2 == 0)
            {
                Console.WriteLine("除數不能為0。");
            }
            sum = num1 / num2;
            Console.WriteLine($"結果是:{num1} / {num2} = {sum}");
            break;
    }
    
}

    
    



