using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBinaryTree
{
    class BinaryTreeNode
    {
        public int key { get; set; }
        public BinaryTreeNode left { get; set; }
        public BinaryTreeNode right { get; set; }

        public bool Isleaf
        {
            get { return left == null && right == null; }
        }

        public bool HasLeft
        {
            get { return left!=null; }
        }
        public bool HasRight
        {
            get { return right != null; }
        }
        public BinaryTreeNode(int value)
        {
            this.key = value;
        }

    }
    class BinaryTree
    {
       public BinaryTreeNode root;
       List<int> list;
       public  int count;
        // khởi tạo
        public BinaryTree()
        {
            root = null;
            count = 0;
            list = new List<int>();
        }
        //addnode
        public virtual bool Add(int value)
        {
            BinaryTreeNode node =new BinaryTreeNode(value);
            if (root == null)
            {
                count++;
                root = node;
                return true;
            }
            return AddNode(root, node);            
        }
        private bool AddNode(BinaryTreeNode node1, BinaryTreeNode node2)
        {
            if (node1.key == node2.key)
                return false;

            if (node1.key > node2.key)
            {

                if (!node1.HasLeft)
                {
                    node1.left = node2;
                    count++;
                    return true;
                }
                else
                    return AddNode(node1.left, node2);
            }
             else
            {
                if (!node1.HasRight)
                {
                    node1.right = node2;
                    count++;
                    return true;
                }
                else return AddNode(node1.right, node2);
            }        
        }
        public virtual int GetHeight()
        {
            return this.GetHeight(this.root);
        }
        private int GetHeight(BinaryTreeNode startNode)
        {
            if (startNode == null)
                return 0;
            else
                return 1 + Math.Max(GetHeight(startNode.left), GetHeight(startNode.right));
        }
    }
}
