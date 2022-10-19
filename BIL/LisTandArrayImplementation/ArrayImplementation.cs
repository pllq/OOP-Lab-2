using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.LisTandArrayImplementation
{
    public class ArrayImplementation
    {
        public static void StartArrayImplementation(Goods[] array_of_goods)
        {
            //Delete from List
            for(int i = array_of_goods.Length-1; i >= array_of_goods.Length-2; i--) 
            {
                array_of_goods[i] = null;
            }
            Array.Resize(ref array_of_goods, array_of_goods.Length -2);

            //Update List
            array_of_goods[0].Quantity_in_the_batch = 1800;
            array_of_goods[0].Cost_per_good = 1250;

            //Search for an item

            var result = Array.Find(array_of_goods, element => element == array_of_goods[3]); // returns "Bill"

            //navigate / go through a dataset.
            Console.WriteLine("Navigate / go through a array:\n");
            foreach (var navigete in array_of_goods)
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
