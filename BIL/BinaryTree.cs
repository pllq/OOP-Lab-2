using System.Collections;

namespace BIL
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }

        List<string> string_to_return = new List<string>();


        public BinaryTree() { }

        public BinaryTree(T data)
        {
            Root = new Node<T>(data);
        }


        public void Insert(params T[] data)
        {
            if (Root != null)
            {
                foreach (T datas in data)
                {
                    Root.Insert(datas);
                }
            }
            else
            {
                Root = new Node<T>(data[0]);
            }
        }

        public List<string> InOrderTraversal(Node<T> data)
        {
            if (data == null) //if data is not assigned
            {
                throw new Exception("Binarty tree is empty.\n");
            }

            //first go to left child its children will be null so we print its Data
            if (data.LeftNode != null)
            {
                InOrderTraversal(data.LeftNode);
            }

            //Then we print/return/add the root node 
            string_to_return.Add(data.Data.ToString());
            //Then we go to the right node which will print itself as both its children are null
            if (data.RightNode != null)
            {
                InOrderTraversal(data.RightNode);
            }

            return string_to_return;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (Root == null)
            {
                throw new Exception("Binarty tree is empty.\n");
            }
            else
            {
                yield return Root.Data;

                if (Root.LeftNode != null)
                {
                    foreach (var v in Root.LeftNode)
                    {
                        yield return v;
                    }
                }

                if (Root.RightNode != null)
                {
                    foreach (var v in Root.RightNode)
                    {
                        yield return v;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
