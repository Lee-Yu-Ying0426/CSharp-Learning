// See https://aka.ms/new-console-template for more information

//正確帳密
string correctUsername = "admin";
string correctPassword = "1234";

//輸入的帳密
string name = "";

//若登入失敗最多可嘗試 3 次
int maxAttempts;
bool isLogin = false;

Console.WriteLine("=====登入系統=====");
//判斷帳號是否有輸入或是否正確
while(name != correctUsername)
{
    Console.Write("請輸入使用者帳號 : ");
    name = Console.ReadLine();
    if (string.IsNullOrEmpty(name)  || name != correctUsername)
    {
        Console.WriteLine("請輸入正確帳號。");
    }
}

for(maxAttempts = 3; maxAttempts > 0;maxAttempts--)
{
    Console.Write("請輸入使用者密碼 : ");
    string password = Console.ReadLine();
    if (password != correctPassword)
    {
        if(maxAttempts == 1)
        {
            Console.WriteLine($" 輸入失敗超過 3 次，帳號已鎖定。");
            break;
        }
        Console.WriteLine($" 密碼錯誤，剩餘 {maxAttempts-1} 次機會\n");
    }
    else
    {
        Console.WriteLine("歡迎登入。");
        isLogin = true;
        break;
    }
}

while (isLogin == true)
{
    Console.WriteLine("\n請選擇功能：\n1. 查詢會員資料\n2. 修改密碼\n3. 登出");
    Console.Write("請輸入選項（1-3）：");
    string option = Console.ReadLine();
    switch (option)
    {
        case "1":
            Console.WriteLine($"這裡是你的會員資料 : \n帳號 : {correctUsername}\n密碼 : {correctPassword}");
            break;
        case "2":
            Console.Write("請輸入要修改的密碼 : ");
            correctPassword = Console.ReadLine();
            break;
        case "3":
            Console.WriteLine("登出成功！");
            isLogin= false;
            break;

        default:
            Console.WriteLine("請輸入有效數字");
            break;
    }
}







