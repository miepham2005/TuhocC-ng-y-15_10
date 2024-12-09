using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuhocC__ngày_15_10
{
    internal class baigiang_1
    {
        public static void Main1()
        {
            //Question_01();
            Question_04();
            Console.ReadKey();
        }
        public static void Question_01()
        {
            Console.Write("Nhap vao 1 ky tu: ");
            int a = Console.Read();
            Console.WriteLine($"ket qua ma ascii cua ky tu la {a}");
        }
        public static void Question_02()
        {
            //tinh dien tich hinh chu nhat
            Console.WriteLine("Nhap chieu dai: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            int b = int.Parse(Console.ReadLine());
            int c = a * b;
            Console.WriteLine($" Ket qua tinh dien tich la: {c}");
        }
        public static void Question_03()
        {
            int a = 7; int b = 8;
            Console.WriteLine(" Voi a = 7, b = 8 va co cac chuc nang sau: ");
            Console.WriteLine(" 1. Phep cong");
            Console.WriteLine(" 2. Phep tru");
            Console.WriteLine(" 3. Phep nhan");
            Console.WriteLine(" 4. Phep chia");
            Console.Write(" Nhap vao ban phim chuc nang ban muon thuc hien <1..4>: ");
            int sel = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int res = 0;
            switch (sel)
            {
                case 1: res = a + b; break;
                case 2: res = a - b; break;
                case 3: res = a * b; break;
                case 4: res = a / b; break;
                default:
                    Console.WriteLine(" Vui long chon so tu 1 den 4.");
                    return;
            }
            Console.WriteLine($"Ket qua cua phep tinh ban chon la: {res}");
        }
        public static void Question_04()//cach su dung cau lenh continue
        {
            int count = 0;
            Console.Write("Nhap mot so nguyen bat ki: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                { continue; }//bo qua lan lap nay va nhay den lan lap tiep theo
                else { count++; }
                if (count == 1) { Console.Write($"Nhung so le be hon {a} bao gom: {i}"); }
                else if (count > 1) { Console.WriteLine($", {i}"); }
            }
        }
        //public static void Question_04()
        //sU dung method overloading
        //mutiple method can have the same name with different parameters
        //binh thuong se co cau truc nhu the nay 
        /*static int Plusmethodint(int a, int b)
        {
            return a + b;
        }
        static double Plusmethoddouble(double a, double b)
        {  return a + b; }
        static void Main(string[] args)
        {
            int Mynum1 = Plusmethodint(6,7);
            double Mynum2= Plusmethoddouble(6.3,7.5);
            Console.WriteLine("int: " + Mynum1);
            Console.WriteLine("double: " + Mynum2);
        }*/
        //we overload Plusmethod to work for int and double 
        static int Plusmethod(int a, int b)
        { return a + b; }
        static double Plusmethod(double a, double b)
        { return a + b; }
        static void Main2(string[] args)
        {
            int Mynum1 = Plusmethod(6, 7);
            double Mynum2 = Plusmethod(6.3, 7.5);
            Console.WriteLine("int: " + Mynum1);
            Console.WriteLine("double: " + Mynum2);
        }
        static int Increasingnumber(ref int a)
        {
            a += 2;
            return a;
        }
        public static void Main3()
        {
            Console.Write("Nhap vao con so ban muon: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So duoc nguoi dung nhap vao: " + a);
            Increasingnumber(ref a);
            Console.WriteLine("So sau khi thay doi: " + a);
        }
        static int tinhtong(int a, int b, out int sum)
        { return sum = a + b; }
        static void Main5()
        {
            int x = 4; int y = 5;
            int result;
            tinhtong(x, y, out result);
            Console.WriteLine("ket qua cua phep toan: " + result);
        }
        static void Main4(string[] args)
        {
            //create an aray of author names
            string[] authors = { "khue pham", "thao nguyen", "mechan", "xi ngay" };
            //call a method that return by ref
            ref string author4 = ref Findauthor(3, authors);
            Console.WriteLine(" original author: " + author4);
            //print author4 in array 
            Console.WriteLine();
            //replace 4th author by new author. by ref, it will update
            author4 = "chris";
            //print author4
            Console.WriteLine("Replaced author: " + authors[3]);
            Console.ReadKey();
        }
        static ref string Findauthor(int number, string[] name)
        {
            if (name.Length > 0)
                return ref name[number];//return the stoarage location, not the value
            throw new IndexOutOfRangeException($"{nameof(number)} not found.");

        }
    }
}

    
