using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_cây_nhị_phân
{
    class BinaryTreeNode
    { 
        public int Value;
        public BinaryTreeNode  LeftChild;  // con trái
        public BinaryTreeNode  RightChild;  // con phải
        public BinaryTreeNode  Parent;      // cha

        // không có nút con
        public bool IsLeaf
        {
            get { return LeftChild == null && RightChild == null; }
        }
        // có con trái
        public bool HasLeft
        {
            get { return LeftChild != null; }
        }
        // có con phải
        public bool HasRight
        {
            get { return RightChild != null; }
        }
        // Khởi tạo
        //contructor
        public BinaryTreeNode(int value)
        {
            this.Value = value;
        }
     
    }
    class BinaryTree
    {
        public BinaryTreeNode Root;
        private List<int> _list; // để lưu trữ các nút giống vói array
        public int Count;

        // khởi tạo 
        public BinaryTree()
        {
            Count = 0;
            _list = new List<int>();
        }
      
        public BinaryTree(int value)
        {
            Add(value);
        }
        // phân vùng cho Add
        #region Add  
        // virtual để cho hàm con nó kế thừa
        public virtual void Add(params int[] values)// params dùng để ko biết số luong tham số dc truyền vào chỉ dugf trong mảng 1 chiều
        {
            Array.ForEach(values, value => Add(value));  // ForEach mảng , hành động1 => hành đônhj2

        }
        public virtual bool Add(int value)
        {
            BinaryTreeNode node = new BinaryTreeNode(value);
            if (Root == null)// nếu rỗng
            {
                Count++;  // tanwg số phần tử lên 1
                Root = node; // nút gốc banwgf gái trị node
                return true; // thông báo gán thành công
            }
            return Add(Root, node);
        }
        private bool Add(BinaryTreeNode parentNode, BinaryTreeNode node)
        {
            if (parentNode.Value.Equals(node.Value))
                return false;

            if (parentNode.Value > node.Value)
            {
                if (!parentNode.HasLeft)
                {
                    parentNode.LeftChild = node;
                    node.Parent = parentNode;
                    Count++;
                    return true;
                }
                else
                    return Add(parentNode.LeftChild, node);
            }
            else
            {
                if (!parentNode.HasRight)
                {
                    parentNode.RightChild = node;
                    node.Parent = parentNode;
                    Count++;
                    return true;
                }
                else
                    return Add(parentNode.RightChild, node);
            }
        }
        #endregion
        public virtual int GetHeight()
        {
            return this.GetHeight(this.Root);
        }
        private int GetHeight(BinaryTreeNode startNode)
        {
            if (startNode == null)
                return 0;
            else
                return 1 + Math.Max(GetHeight(startNode.LeftChild), GetHeight(startNode.RightChild));
        }
        public virtual void ClearChildren(BinaryTreeNode node)
        {

            if (node.HasLeft)
            {
                ClearChildren(node.LeftChild);
                node.LeftChild.Parent = null;
                node.LeftChild = null;
            }
            if (node.HasRight)
            {
                ClearChildren(node.RightChild);
                node.RightChild.Parent = null;
                node.RightChild = null;
            }
        }
        public virtual void Clear()
        {
            if (Root == null)
                return;
            ClearChildren(Root);
            Root = null;
            Count = 0;
        }
        public virtual BinaryTreeNode Search(int value)
        {
            return Search(Root, value);
        }
        public virtual BinaryTreeNode Search(BinaryTreeNode node, int value)
        {
            if (node == null)
                return null;
            if (node.Value.Equals(value))
                return node;
            else
            {
                if (node.Value.CompareTo(value) > 0)
                    return Search(node.LeftChild, value);
                else
                    return Search(node.RightChild, value);
            }
        }
        public virtual Queue<int> FindPath(int value)
        {
            Queue<int> q = new Queue<int>();

            BinaryTreeNode node = this.Root;
            bool isFounded = false;

            while (node != null)
            {
                if (node.Value.Equals(value))
                {
                    isFounded = true;
                    break;
                }
                else
                {
                    if (node.Value.CompareTo(value) > 0)
                        node = node.LeftChild;
                    else
                        node = node.RightChild;

                    if (node != null) q.Enqueue(node.Value);
                }
            }
            if (!isFounded)
            {
                q.Clear();
                q = null;
            }

            return q;
        }
        #region InOrder Traversal
        public virtual List<int> InOrderTraverse()
        {
            _list.Clear();
            InOrderTraverse(Root);
            return _list;
        }
        private void InOrderTraverse(BinaryTreeNode node)
        {
            if (node == null)
                return;
            InOrderTraverse(node.LeftChild);
            _list.Add(node.Value);
            InOrderTraverse(node.RightChild);
        }
        #endregion

        #region PreOrder Traversal
        public virtual List<int> PreOrderTraverse()
        {
            _list.Clear();
            PreOrderTraverse(Root);
            return _list;
        }
        private void PreOrderTraverse(BinaryTreeNode node)
        {
            if (node == null)
                return;
            _list.Add(node.Value);
            PreOrderTraverse(node.LeftChild);
            PreOrderTraverse(node.RightChild);
        }
        #endregion

        #region PostOrder Traversal
        public virtual List<int> PostOrderTraverse()
        {
            _list.Clear();
            PostOrderTraverse(Root);
            return _list;
        }
        private void PostOrderTraverse(BinaryTreeNode node)
        {
            if (node == null)
                return;
            PostOrderTraverse(node.LeftChild);
            PostOrderTraverse(node.RightChild);
            _list.Add(node.Value);
        }
        #endregion
    }
}
