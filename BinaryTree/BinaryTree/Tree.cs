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
<<<<<<< HEAD
        //xóa node
         public bool Remove(BSTree root,int key)
=======
        // xóa
        public bool Remove(BSTree root,int key)
>>>>>>> 4981c5b3ebd8b8528933db999ef2982f1332b304
        {
            if (root == null)
                return false;
            if (root.data > key)
                return Remove(root.left, key);
            if (root.Data < key)
                return Remove(root.right, key);
            if (root.left == null)
            {
                root = root.right;
                root.right = null;
                
            }
            else if (root.right == null)
            {
                root = root.left;
                root.left = null;
            }
            else
            {
                BSTree p = root.right;
                MoveLeftMostNode(p, root);
            }
            return true;
        }
        public void MoveLeftMostNode(BSTree p, BSTree root)
        {
            if (p.left != null)
                MoveLeftMostNode(p.left, root);
            else
            {
                root.data = p.data;
                p = p.right;
                p.right = null;
            }
<<<<<<< HEAD
        }  
        //tính chiều cao cây nhị phân
        public int ChieuCao(BSTree root)
        {
            if (root==null)
                return 0;
            int a = ChieuCao(root.left);//con trỏ bên trái//
            int b = ChieuCao(root.right);//con trỏ bên phải//
            if (a > b)
                return (a + 1);
            return (b + 1);            
        }
        //tính số nút lá
        public int CountLeaf(BSTree root)
        {
            int n = 0;
            if (root == null)
                return 0;
            else
                if (IsLeafNode(root) == 1) return 1;
            else return CountLeaf(root.right) + CountLeaf(root.left);          
        }
=======
        }

>>>>>>> 4981c5b3ebd8b8528933db999ef2982f1332b304
    }
}
