using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caynhiphancodeCsharp
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Tree tr = new Tree();
            int key;
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                key = rd.Next(100);
                Console.Write(key + " ");
                tr.InsertNode(key);
            }
                int x;
            Console.WriteLine("nhap vao gai tri ban can tim");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(tr.Search(tr.root, x));
            Console.WriteLine("\n\nDuyet tien tu:");
            tr.PreorderTraverse(tr.root);
            Console.WriteLine("\n\nDuyet trung tu:");
            tr.InorderTraverse(tr.root);
            Console.WriteLine("\n\nDuyet hau tu:");
            tr.PostorderTraverse(tr.root);
           
           
        }
    }
    class BSTree
    {
        public int data;
        public BSTree left;
        public BSTree right;
        
        public BSTree(int key) {
            data = key;
            left = null;
            right = null;
        }
        public void Insert(int key)
        {
            if (key < data)
            {
                if (left == null) left = new BSTree(key);
                else left.Insert(key);
            }
            if (key > data)
            {
                if (right == null) right = new BSTree(key);
                else right.Insert(key);
            }
        }
    }
    class Tree
    {
        // tạo cây rỗng
       public BSTree root;  
        public Tree()
        {
            root = null;
        }
        // kiểm tra cây rỗng
        public int IsEmptyTree(BSTree root)
        {
            if (root == null) return 0;
            return 1;
        }
        // kiểm tra nút lá
        public int IsLeatNode(BSTree root)
        {
            if (root.left == null && root.right == null)
                return 1;
            return 0;
        }
        public void InsertNode( int key)
        {

            if (root == null)
                root = new BSTree(key);
            else root.Insert(key);
        }
        public bool Search(BSTree node,int key) {
            if (node == null)
                return false;
            if (node.data == key)
                return true;
            if (node.data > key)
                 return Search(node.left, key);
            if (root.data < key)
                return Search(node.right, key);
            else return false;
        }
        public void PreorderTraverse(BSTree node)
        {
            if (node == null) return;
            Console.Write(node.data + " ");
            PreorderTraverse(node.left);
            PreorderTraverse(node.right);
        }
        public void InorderTraverse(BSTree node)
        {
            if (node == null) return;
            InorderTraverse(node.left);
            Console.Write(node.data + " ");
            InorderTraverse(node.right);
        }
        public void PostorderTraverse(BSTree node)
        {
            if (node == null) return;
            PostorderTraverse(node.left);
            PostorderTraverse(node.right);
            Console.Write(node.data + " ");
        }
        
    }
}
