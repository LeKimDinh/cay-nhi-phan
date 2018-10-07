using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {
        //tạo cây rỗng
        public BSTree root;
        public Tree()
        {
            root = null;
        }
        //kiểm tra cây rỗng
        public int IsEmptyTree(BSTree root)
        {
            if (root == null)
                return 0;
            return 1;
        }
        //chèn vào node
        public void InsertNode(int key)
        {
            if (root == null)
                root = new BSTree(key);
            else root.Insert(key);
        }
        //kiểm tra nút lá
        public int IsLeafNode(BSTree root)
        {
            if (root.left == null && root.right == null)
                return 1;
            return 0;
        }
        //Duyệt tiền tự
        public void PreOrder(BSTree root)
        {
            if (root == null) return;
            Console.Write(root.data + " ");
            PreOrder(root.left);
            PreOrder(root.right);            
        }
        //Duyệt trung tự
        public void InOrder(BSTree root)
        {
            if (root == null) return;
            InOrder(root.left);
            Console.Write(root.data + " ");
            InOrder(root.right);
        }
        //Duyệt hậu tự
        public void PostOrder(BSTree root)
        {
            if (root == null) return;
            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write(root.data + " ");
        }
        //Tìm kiếm
        public bool Search(BSTree root, int key)
        {
            if (root == null)
                return false;
            if (root.data == key)
                return true;
            if (root.data > key)
                return Search(root.left, key);
            if (root.data < key)
                return Search(root.right, key);
            else return false;

        }
           
    }
}
