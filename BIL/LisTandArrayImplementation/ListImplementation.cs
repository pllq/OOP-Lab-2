using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.LisTandArrayImplementation
{
    public class ListImplementation
    {
        public static void StartListImplementation(List<Goods> GoodsList) 
        {
            //Delete from List
            GoodsList.Remove(GoodsList[0]);
            GoodsList.RemoveAt(2);
            GoodsList.RemoveAt(4);
            GoodsList.RemoveRange(2, 2);

            //Update List
            GoodsList[0].Quantity_in_the_batch = 1800;
            GoodsList[0].Cost_per_good = 1250;

            //Search for an item
            Goods find_a_good = GoodsList.Find(x => x.Name.Contains("Samsung Galaxy Z Flip 3"));

            //navigate / go through a dataset.
            Console.WriteLine("Navigate / go through a list:\n");
            foreach (var navigete in GoodsList)
            {
                Console.WriteLine
                    (
                        $"Cost per good: {navigete.Cost_per_good}$, " +
                        $"Manufacturer: {navigete.Manufacturer}, " +
                        $"Name: {navigete.Name}, " +
                        $"Code: {navigete.Code}, " +
                        $"Quantity in the batch of goods: {navigete.Quantity_in_the_batch} items, " +
                        $"Total cost of the batchof goods: {navigete.Total_cost_of_the_batch}$."
                    );
            }
            Console.WriteLine("____________________________________________________________________________________________\n");
        }
    }
}
