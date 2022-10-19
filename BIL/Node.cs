using System.Collections;

namespace BIL
{
    public class Node<T> : IEnumerable<T> where T : IComparable<T>
    {
        public Node<T> RightNode { get; set; } //Right Child
        public Node<T> LeftNode { get; set; } //Right Child
        public T Data { get; set; }

        //Node constructor

        public Node(){}

        public Node(T value)
        {
/*            RightNode = null;
            LeftNode = null;*/
            Data = value;
        }

        //recursively calls insert down the tree until it find an open spot
        public void Insert(T data)
        {
            if (this.Data.CompareTo(data) < 0)
            {
                if (this.RightNode == null)
                {
                    this.RightNode = new Node<T>(data);
                }
                else
                {
                    this.RightNode.Insert(data);
                }
            }
            else
            {
                if (this.LeftNode == null)
                {
                    this.LeftNode = new Node<T>(data);
                }
                else
                {
                    this.LeftNode.Insert(data);
                }
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            yield return Data;
            if (LeftNode != null)
            {
                foreach (T child in LeftNode)
                {
                    yield return child;
                }
            }
            if (RightNode != null)
            {
                foreach (T child in RightNode)
                {
                    yield return child;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
