using BIL;
using BIL.LisTandArrayImplementation;

namespace MainProject
{
    internal class ConsoleProgram
    {
        public static void StartConsoleProgram()
        {
            //Task 1 

            Goods first = new Goods("800123456789", "Sandales", "Gucci", 890, 1000);
            Goods second = new Goods("800123456789", "T-Shirts", "Gucci", 1300, 2000);
            Goods third = new Goods("800123456789", "Shorts", "Gucci", 706, 400);
            Goods fourth = new Goods("030123456789", "IPhone X", "Apple", 404.99, 1000);
            Goods fifth = new Goods("030123456789", "IPhone 13", "Apple", 899, 3500);
            Goods sixth = new Goods("030123456789", "IPhone 14", "Apple", 1499, 10000);
            Goods seventh = new Goods("482123456789", "Samsung Galaxy A53", "Samsung", 344.99, 10000);
            Goods eighth = new Goods("482123456789", "Samsung Galaxy Z Flip 3", "Samsung", 644.99, 750);
            Goods nineth = new Goods("482123456789", "Samsung Galaxy S22", "Samsung", 799.99, 8000);

            //Task 2
            //
            //List Implementation
            List<Goods> GoodsList = new List<Goods>();
            GoodsList.Add(first);
            GoodsList.Add(second);
            GoodsList.Add(third);
            GoodsList.Add(fourth);
            GoodsList.Add(fifth);
            GoodsList.Add(sixth);
            GoodsList.Add(seventh);
            GoodsList.Add(eighth);
            GoodsList.Add(nineth); 
            ListImplementation.StartListImplementation(GoodsList);

            //Array Implementation
            Goods[] array_of_goods = { first, second, third, fourth, fifth, sixth };
            ArrayImplementation.StartArrayImplementation(array_of_goods);
            //

            //Task 3-4
            first.Increase_the_Cost_by_certain_percentage();
            third.Increase_the_Cost_by_certain_percentage();
            seventh.Increase_the_Cost_by_certain_percentage();
            nineth.Increase_the_Cost_by_certain_percentage();

            BinaryTree<Goods> binaryTree = new BinaryTree<Goods>(first);

            binaryTree.Insert(second, third, fourth, fifth, sixth, seventh, eighth, nineth);

            Console.WriteLine("InOrder traversal (sorted by cost):\n");
            try
            {
                foreach (var my_string in binaryTree.InOrderTraversal(binaryTree.Root))
                {
                    Console.WriteLine(my_string);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            Console.WriteLine("____________________________________________________________________________________________\n");


            Console.WriteLine("Implemented iterator, using the <IEnumerable> and <IEnumerator>:\n");
            try
            {
                foreach (var data_from_binaryTree in binaryTree) //this throws to BinaryTree.cs public IEnumerator<T> GetEnumerator()
                {
                    Console.WriteLine
                        (
                            $"Cost per good: {data_from_binaryTree.Cost_per_good}$, " +
                            $"Manufacturer: {data_from_binaryTree.Manufacturer}, " +
                            $"Name: {data_from_binaryTree.Name}, " +
                            $"Code: {data_from_binaryTree.Code}, " +
                            $"Quantity in the batch of goods: {data_from_binaryTree.Quantity_in_the_batch} items, " +
                            $"Total cost of the batchof goods: {data_from_binaryTree.Total_cost_of_the_batch}$."
                        );
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            Console.ReadLine();
        }
    }
}
