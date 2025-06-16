// See https://aka.ms/new-console-template for more information

//讓使用者輸入一個 0～100 的成績數字，然後顯示對應的等級。

while (true)
{
    Console.WriteLine("=====成績等級判斷0~100=====");
    Console.Write("請輸入你的成績(或輸入Q離開) : ");
    //bool is_val = double.TryParse(Console.ReadLine(), out double score);

    //輸入Q離開
    string val = Console.ReadLine();
    if (val == "Q") break;

    //判斷是否為有效數字
    bool is_val = double.TryParse(val, out double score);
    if (!is_val)
    {
        Console.WriteLine("請輸入有效數字。");
        continue;
    }

    //如果分數尾數在 7~9 ➜ 顯示「+」
    //如果分數尾數在 0~2 ➜ 顯示「-」
    //其他則不加符號

    string suffix = ""; 
    if (score % 10 >= 7)  suffix = "+";
    else if(score % 10 <= 2) suffix = "-";

    if (score >= 90 && score <= 99) Console.WriteLine($"你的等級是：A{suffix}。");
    else if (score == 100) Console.WriteLine($"你的等級是：A+。");
    else if (score >= 80 && score <= 89) Console.WriteLine($"你的等級是：B{suffix}。");
    else if (score >= 70 && score <= 79) Console.WriteLine($"你的等級是：C{suffix}。");
    else if (score >= 60 && score <= 69) Console.WriteLine($"你的等級是：D{suffix}。");
    else if (score >= 0 && score <= 59) Console.WriteLine($"你的等級是：F。");
    else Console.WriteLine("成績不能小於 0 或大於 100。");
}


