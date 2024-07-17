internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double a, b, c; 
        Console.WriteLine("Nhập hệ số a ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập hệ số b ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập hệ số c ");
        c = Convert.ToDouble(Console.ReadLine());
       double delta = b * b - 4 * a * c;
        PTBac2cach1(a, b,c, delta);
    }
    private static void PTBac2cach1(double a, double b, double c, double delta)
    {
        if (delta == 0) Console.WriteLine("PT vô số nghiệm " + (-b / 2 * a).ToString());
        {
            if (delta < 0) Console.WriteLine("PT vô nghiệm ");


            else Console.WriteLine("PT có 2 nghiệm la: " + Math.Round((-b + Math.Sqrt(delta)) / (2 * a) + (-b - Math.Sqrt(delta)) / (2 * a)),4);


        }


    }

}