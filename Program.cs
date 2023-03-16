using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] arr = new int[10];
            Console.Write("\nNhap so phan tu:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri cac phan tu:\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap gia tri phan tu thu " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Mang da nhap:\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Gia tri phan tu thu " + (i + 1) + " la: " + arr[i]);
            }

            // cau 2
            int chan = 0;
            int le = 0;
            Console.WriteLine("\nCau 2: Tong cac pt chan le.");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    chan += arr[i];
                }
                else
                {
                    le += arr[i];
                }
            }
            Console.WriteLine("Tong cac pt chan la: " + chan);
            Console.WriteLine("Tong cac pt le: " + le);

            // cau 3: sx tang dan
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int x = arr[j];
                        arr[j] = arr[i];
                        arr[i] = x;
                    }
                }
            }
            Console.WriteLine("\nCau 3: Mang da sx tang dan:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + ", ");
            }

            // cau 4: sx giam dan
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int x = arr[j];
                        arr[j] = arr[i];
                        arr[i] = x;
                    }
                }
            }
            Console.WriteLine("\nCau 4: Mang da sx giam dan:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + ", ");
            }

            // Cau5: them 1 pt
            int a, b;
            Console.WriteLine("\nCau5: Chen them 1 pt:");
            Console.WriteLine("\nNhap vi tru muon chen:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap gia tri muon chen:");
            b = int.Parse(Console.ReadLine());

            for (int i = n; i >= a; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[a] = b;
            n++;
            Console.WriteLine("\nMang da them 1 pt moi::");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + ", ");
            }

            // Cau 6: Xoa 1 pt
            int c;
            Console.WriteLine("\nCau6: Xoa 1 pt:");
            Console.WriteLine("Nhap vi tri muon xoa:");
            c = int.Parse(Console.ReadLine());
            for (int i = c; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            n--;
            Console.WriteLine("\nMang da xoa 1 pt:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }
    }
}
