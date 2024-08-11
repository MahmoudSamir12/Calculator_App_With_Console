Console.WriteLine("\t\t\t\t\t\t\tCalculator App\r");
Console.WriteLine("\t\t\t\t\t\t\t----------------");

//================================================= First Way ===============================

//int num1;
//int num2;
//int result;

//Console.WriteLine("Enter First Number : ");
//num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Second Number : ");
//num2 = Convert.ToInt32(Console.ReadLine());

////Console.WriteLine("Enter the action to be performed");
////Console.WriteLine("Press + for Addition");
////Console.WriteLine("Press - for Subtraction");
////Console.WriteLine("Press * for Multiplication");
////Console.WriteLine("Press / for Division \n");

//Console.WriteLine("Enter Symbol of operation you want (+,-,*,/) : ");
//string operationSymbol;
//operationSymbol = Console.ReadLine();


//if (operationSymbol == "+")
//{
//    result = num1 + num2;
//    Console.WriteLine("Addition Operation for the two entered numbers  = " + result);
//}
//else if (operationSymbol == "-")
//{
//    result = num1 - num2;
//    Console.WriteLine("Subtration Operation for the two entered numbers = " + result);
//}
//else if (operationSymbol == "*")
//{
//    result = num1 * num2;
//    Console.WriteLine("Multiplication Operation for the two entered numbers = " + result);
//}
//else
//{
//     result = num1 / num2;
//     Console.WriteLine("Divition Operation for the two entered numbers = " + result);

//}

//============================================= Second Way ================================

string value;
do
{
    int res;
    Console.WriteLine("Enter First Number : ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Second Number : ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Symbol of operation you want (+,-,*,/):");
    string symbol = Console.ReadLine();

    switch (symbol)
    {
        case "+":
            res = num1 + num2;
            Console.WriteLine("Addition : " + res);
            break;
        case "-":
            res = num1 - num2;
            Console.WriteLine("Subtraction : " + res);
            break;
        case "*":
            res = num1 * num2;
            Console.WriteLine("Multiplication : " + res);
            break;
        case "/":
            res = num1 / num2;
            Console.WriteLine("Division : " + res);
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }
    Console.ReadLine();
    Console.Write("Do you want to continue(y/n):");
    value = Console.ReadLine();
}
while (value == "y" || value == "Y");

