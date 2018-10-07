using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BSTree
    {
        public int data;
        public BSTree left;
        public BSTree right;
        public BSTree(int key)
        {
            data = key;
            left = right = null;
        }
        public BSTree Left
        {
            get { return left; }
            set { left = value; }
        }
        public BSTree Right
        {
            get { return right; }
            set { right = value; }
        }
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public void Insert (int key)
        {
            if (key < data)
            {
                if (left == null)
                    left = new BSTree(key);
                else left.Insert(key);
            }
            if (key > data)
            {
                if (right == null)
                    right = new BSTree(key);
                else right.Insert(key);
            }
        }
    }
}
