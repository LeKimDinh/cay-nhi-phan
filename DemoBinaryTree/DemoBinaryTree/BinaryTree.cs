using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBinaryTree
{
    class BinaryTreeNode
    {
        public int key;
        public BinaryTreeNode left;
        public BinaryTreeNode right;
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
       List<int> _list;
       public  int count;
        // khởi tạo
        public BinaryTree()
        {
            root = null;
            count = 0;
            _list = new List<int>();
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
        public virtual Queue<int> ADD(int value)
        {
            Queue<int> q = new Queue<int>();
            BinaryTreeNode node = this.root;
            BinaryTreeNode node1 = new BinaryTreeNode(value);
            bool isFounded = true;

            if (node == null)
            {
                node = node1;
                node.left = node.right = null;
                q.Enqueue(node.key);
                return q;
            }
            while (node != null)
            {
                if (node.key.Equals(value))
                {
                    isFounded = false;
                    break;
                }
                else
                {
                    if (node.key.CompareTo(value) > 0)
                    {

                        if (!node.HasLeft)
                        {
                            node.left = node1;
                            q.Enqueue(node.left.key);
                            return q;
                        }
                        else node = node.left;
                    }
                    else
                    {

                        if (!node.HasRight)
                        {
                            node.right = node1;
                            q.Enqueue(node.right.key);
                            return q;
                        }
                        else node = node.right;
                    }
                }
                if (node != null)
                    q.Enqueue(node.key);
            }
            if (isFounded == false)
            {
                q.Clear();
                q = null;
            }
            return q;
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
        public virtual void ClearChildren(BinaryTreeNode node)
        {

            if (node.HasLeft)
            {
                ClearChildren(node.left);
                node.left = null;
            }
            if (node.HasRight)
            {
                ClearChildren(node.right);
                node.right= null;
            }
        }
        public virtual void Clear()
        {
            if (root == null)
                return;
            ClearChildren(root);
            root = null;
            count = 0;
        }
        public virtual Queue<int> FindPath(int value)
        {
            Queue<int> q = new Queue<int>();
            BinaryTreeNode node = this.root;
            bool isFound = false;
            while (node != null)
            {
                if (node.key.Equals(value))
                {
                    isFound = true;
                    break;
                }
                else
                {
                    if (node.key.CompareTo(value) > 0)
                        node = node.left;
                    else
                        node = node.right;
                    if (node != null)
                        q.Enqueue(node.key);
                }
            }
            if (!isFound)
            {
                q.Clear();
                q = null;
            }
            return q;
        }
        public virtual List<int> InOrderTraverse()
        {
            _list.Clear();
            InOrderTraverse(root);
            return _list;
        }
        private void InOrderTraverse(BinaryTreeNode node)
        {
            if (node == null)
                return;
            InOrderTraverse(node.left);
            _list.Add(node.key);
            InOrderTraverse(node.right);
        }
        public virtual List<int> PreOrderTraverse()
        {
            _list.Clear();
            PreOrderTraverse(root);
            return _list;
        }
        private void PreOrderTraverse(BinaryTreeNode node)
        {
            if (node == null)
                return;
            PreOrderTraverse(node.left);          
            PreOrderTraverse(node.right);
            _list.Add(node.key);
        }

        public virtual List<int> PostOrderTraverse()
        {
            _list.Clear();
            PostOrderTraverse(root);
            return _list;
        }
        private void PostOrderTraverse(BinaryTreeNode node)
        {
            if (node == null)
                return;
            _list.Add(node.key);
            PostOrderTraverse(node.left);
            PostOrderTraverse(node.right);
            
        }
       public int x;

        public virtual bool Remove(int value)
        {
            return Remove(ref root, value,ref x);
        }
        private bool Remove(ref BinaryTreeNode root, int value,ref int x)
        {
            if (root == null)
                return false;
            if (root.key == value)
            {
                if (root.left == null && root.right == null)
                {
                    root = null;
                }
                else
                {
                    if (root.left == null)
                    {
                        root = root.right;
                        root.right = null;
                       
                        x = root.key;
                    }
                    else
                    {
                        if (root.right == null)
                        {
                            root = root.left;
                            root.left = null;
                           
                            x = root.key;
                        }
                        else
                        {
                            MoveLeftMostNode(ref root.right, root);
                            Remove(ref root.right, root.right.key,ref x);
                        }

                    }
                }
            }
            else
            {
                if (root.key > value)
                {
                    return Remove(ref root.left, value,ref x);
                }
                if (root.key < value)
                {
                    return Remove(ref root.right, value,ref x);
                }
            }
            count--;
            return true;
        }
        private void MoveLeftMostNode(ref BinaryTreeNode p, BinaryTreeNode root)
        {
            if (p.left != null)
                MoveLeftMostNode(ref p.left, root);
            else
            {
                root.key = p.key;
            }
        }
    }
}
