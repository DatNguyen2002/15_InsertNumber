using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khởi tạo mảng mặc định bao gồm 10 phần tử và cho sẵn giá trị
            int[] mang = { 1, 2, 3, 4, 5, 6, 0, 0, 0, 0 };
            // gán gias trị mặc định cho mảng
            //for(int i = 0; i < mang.Length; i++)
            //{
            //    mang[i] = 0;
            //}

            //nhap phan tu moi
            //int phanTuMoi = 6;
            Console.WriteLine("Nhap so ban muon them vao: ");
            int phanTuMoi = int.Parse(Console.ReadLine());

            //Nhap vi tri can nhap can gan
            //int viTriCanVao = 3;
            Console.WriteLine("Nhap vi tri ban muon them vao: ");
            int viTriCanVao  = int.Parse(Console.ReadLine());

            //kierm tra neu vi tri nhap hop le 
            if (viTriCanVao >= 0 && viTriCanVao < mang.Length)
            {
                // di chuyen phan tu phi sau lui lai mot o
                for(int i =mang.Length - 1; i > viTriCanVao; i--)
                {
                    mang[i] = mang[i - 1];
                }

                //gan gia tri da nhap vao vao vi tri can cho vao
                mang[viTriCanVao] = phanTuMoi;
            }

            //in ra mang can cho vao
            Console.WriteLine("Ta co mang moi: ");
            foreach(int i in mang)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
