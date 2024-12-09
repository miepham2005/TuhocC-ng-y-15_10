// See https://aka.ms/new-console-template for more information
namespace Session02
    {
    internal class Exercise_01
{
    public static void Main()
    {
            //Question_01();
            //Question_02();
            //Question_04();
            Console.ReadKey();
                }
    public static void Question_01()
    {
        Console.Write("Nhap so a: "); 
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
            }
        public static void Question_02()
        {
            Console.Write("Nhap a: ");
            object a = Console.ReadLine();
            Console.Write("Nhap b: ");
            object b = Console.ReadLine();
            object c = a;
            Console.WriteLine($"a = {b}");
            Console.WriteLine($"b = {c}");
        }
        public static void Question_03()
        {
            Console.Write("Nhap so a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Double c = a * b;
            Console.WriteLine($"{a} * {b} = {c}"); 
        }
        public static void Question_04()
        {
            Console.Write("Nhap so feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double met = feet * 0.3048;
            Console.WriteLine($"{feet} feet = {met} met");
                }
        public static void Question_05()
        {
            Console.Write("Nhap do c: ");
            double do_c1 = Convert.ToDouble(Console.ReadLine());
            double do_f1 = do_c1 * 9 / 5 + 32;
            Console.WriteLine($"ket qua doi thanh do f la {do_f1}");
            Console.Write("Nhap do f: ");
            double do_f2 = Convert.ToDouble(Console.Readline());
            double do_c2 = (do_f2 - 32) * 5 / 9;
            Console.WriteLine($"ket qua doi thanh do c la {do_c2}")
        }
}
    }

