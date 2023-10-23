public class Calculator {
        public double Sum(double a, double b){
        return a + b;
    }
            public double Minus(double a, double b){
        return a - b;
    }
            public double Multpily(double a, double b){
        return a * b;
    }
            public double Devid(double a, double b){
        return a / b;
    }
}

public class Request
{
    Calculator calculate;

    public Request(Calculator calculate){
        this.calculate = calculate;
    }
    public void Req()
    {

        while (true)
        {
            Console.Clear();
            double a, b;
            string action;


            try
            {
                Console.WriteLine("Введите первое число");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите действие");
                action = Console.ReadLine();

                Console.WriteLine("Введите второе число");
                b = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка. Введено не число");
                Console.ReadLine();
                continue;
            }
            switch (action)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;

                case "-":
                    Console.WriteLine(a - b);
                    break;

                case "*":
                    Console.WriteLine(a * b);
                    break;

                case "/":

                    if (b == 0)
                    {
                        Console.WriteLine("Делить на 0 нельзя");
                    }
                    else
                    {
                        Console.WriteLine(a / b);
                    }
                    break;

                default:
                    Console.WriteLine("Неизвестное действие");
                    break;
            }
            Console.ReadLine(); 
        }

    }
}

class Program {
    static void Main(string[] args){
        Calculator calculate = new Calculator();
        Request req = new Request(calculate);
        req.Req();
    }
}