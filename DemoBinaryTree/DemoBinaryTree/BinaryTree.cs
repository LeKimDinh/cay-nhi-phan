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
        public BinaryTreeNode parent { get; set; }
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
                    node2.parent = node1;
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
                    node2.parent = node1;
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
        public virtual void ClearChildren(BinaryTreeNode node)
        {

            if (node.HasLeft)
            {
                ClearChildren(node.left);
                node.left.parent = null;
                node.left = null;
            }
            if (node.HasRight)
            {
                ClearChildren(node.right);
                node.right.parent = null;
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
            bool isFounded = false;
            while (node != null)
            {
                if (node.key.Equals(value))
                {
                    isFounded = true;
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
            if (!isFounded)
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

        public virtual bool Remove(int value)
        {
            return Remove(root, value);
        }
        private bool Remove(BinaryTreeNode root, int value)
        {
            if (root == null)
                return false;
            if (root.key > value)
            {
                return Remove(root.left, value);
            }
            else
            {
                if (root.key < value)
                {
                    return Remove(root.right, value);
                }
                else
                {
                    if (root.Isleaf)   // 0 co con
                    {
                        if (root.parent.left == root)
                            root.parent.left = null;
                        else if (root.parent.right == root)
                            root.parent.right = null;
                    }
                    else
                    {
                        if (root.HasLeft && root.HasRight) //2 con
                        {
                            BinaryTreeNode p = root.right;
                            MoveLeftMostNode(p, root);
                            Remove(p, p.key);
                        }  
                        else // 1 con
                        {
                            BinaryTreeNode subNode;
                            if(root.HasLeft)
                            {
                                subNode = root.left;
                            }
                            else
                            {
                                subNode = root.right;
                            }
                            if (root == (subNode))
                                root = subNode;

                            subNode.parent = root.parent;

                            if (root.parent.left == root)
                                root.parent.left = subNode;
                            else
                                root.parent.right = subNode;
                        }
                        
                    }
                    count--;
                    return true;
                }
            }
        }
        private void MoveLeftMostNode(BinaryTreeNode p, BinaryTreeNode root)
        {
            if (p.left != null)
                MoveLeftMostNode(p.left, root);
            else
            {
                root.key = p.key;
            }
        }



    }
}
