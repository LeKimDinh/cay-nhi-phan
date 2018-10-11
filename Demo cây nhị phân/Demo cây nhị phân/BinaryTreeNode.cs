using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_cây_nhị_phân
{
    class BinaryTreeNode<T>    // T là kiểu dữ liệu
        where T:IComparable    
    {
        public T Value;
        public BinaryTreeNode<T> LeftChild;  // con trái
        public BinaryTreeNode<T> RightChild;  // con phải
        public BinaryTreeNode<T> Parent;      // cha

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
        public BinaryTreeNode(T value)
        {
            this.Value = value;
        }
        //toán tử so sánh
        public static bool operator <(BinaryTreeNode<T> node1, BinaryTreeNode<T> node2)
        {
            //node1<node2
            return node1.Value.CompareTo(node2.Value) < 0;
        }
        public static bool operator >(BinaryTreeNode<T> node1, BinaryTreeNode<T> node2)
        {
            //node1>node2
            return node1.Value.CompareTo(node2.Value) > 0;
        }
    }
    class BinaryTree<T>
        where T:IComparable
    {
        public BinaryTreeNode<T> Root;
        private List<T> _list; // để lưu trữ các nút giống vói array
        public int Count;

        // khởi tạo 
        public BinaryTree()
        {
            Count = 0;
            _list = new List<T>();
        }
      
        public BinaryTree(T value)
        {
            Add(value);
        }
        // phân vùng cho Add
        #region Add  
        // virtual để cho hàm con nó kế thừa
        public virtual void Add(params T[] values)// params dùng để ko biết số luộng tham số dc truyền vào chỉ dugf trong mảng 1 chiều
        {
            Array.ForEach(values, value => Add(value));  // ForEach mảng , hành động1 => hành đônhj2

        }
        public virtual bool Add(T value)
        {
            BinaryTreeNode<T> node = new BinaryTreeNode<T>(value);
            if (Root == null)// nếu rỗng
            {
                Count++;  // tanwg số phần tử lên 1
                Root = node; // nút gốc banwgf gái trị node
                return true; // thông báo gán thành công
            }
            return Add(Root, node);
        }
        private bool Add(BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)
        {
            if (parentNode.Value.Equals(node.Value))
                return false;

            if (parentNode > node)
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
        private int GetHeight(BinaryTreeNode<T> startNode)
        {
            if (startNode == null)
                return 0;
            else
                return 1 + Math.Max(GetHeight(startNode.LeftChild), GetHeight(startNode.RightChild));
        }
        public virtual void ClearChildren(BinaryTreeNode<T> node)
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
    }
}
