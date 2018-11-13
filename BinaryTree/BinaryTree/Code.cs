using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Code
    {
        static void Main(string[] args)
        {
            Tree tr = new Tree();
            int key;
            Random rd = new Random();
            for(int i=0;i<10;i++)
            {
                key = rd.Next(100);
                Console.Write(key + " ");
                tr.InsertNode(key);
            }
            int x;
            Console.WriteLine();
            Console.Write("Nhap vao gia tri ban can tim: ");
            x = int.Parse(Console.ReadLine());
            //Console.WriteLine(tr.Search(tr.root, x));
            //Console.WriteLine("Duyet tien tu:");
            //tr.PreOrder(tr.root);
            //Console.WriteLine();
            //Console.WriteLine("Duyet trung tu: ");
            //tr.InOrder(tr.root);
            //Console.WriteLine();
            //Console.WriteLine("Duyet hau tu: ");
            //tr.PostOrder(tr.root);
            //Console.WriteLine();
            //Console.Write("Chieu cao lon nhat cua cay: ");
            //int kq = Convert.ToInt32(tr.ChieuCao(tr.root));
            //Console.WriteLine(kq);
            tr.Output(tr.root);
            Console.WriteLine();
            Console.WriteLine("Cay sau khi xoa node: ");
            Console.WriteLine(tr.Remove(ref tr.root, x));
            tr.Output(tr.root);
            //Console.WriteLine();
            //Console.Write("So nut la cua cay: ");
            //Console.WriteLine(tr.CountLeaf(tr.root));
            Console.WriteLine();
        }
    }
}
