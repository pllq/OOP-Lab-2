namespace BIL
{
    public class Goods : IComparable<Goods>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Cost_per_good { get; set; }
        public uint Quantity_in_the_batch { get; set; }
        public double Total_cost_of_the_batch {get; private set;}


        public Goods(string arg_Code, string arg_Name, string arg_Manufacturer, double arg_Cost_per_good, uint arg_Quantity_in_the_batch_of_goods) 
        {
            Code = arg_Code;
            Name = arg_Name;
            Manufacturer = arg_Manufacturer;
            Cost_per_good = arg_Cost_per_good;
            Quantity_in_the_batch = arg_Quantity_in_the_batch_of_goods;
            Total_cost_of_the_batch_is_equal();
        }

        private void Total_cost_of_the_batch_is_equal()
        {
            Total_cost_of_the_batch = this.Cost_per_good * Quantity_in_the_batch;
        }

        public void Increase_the_Cost_by_certain_percentage()
        {
            var random_double = new Random();
            double percentage_to_increase = 0;

            //random.NextDouble() * (maximum - minimum) + minimum; //range
            percentage_to_increase = random_double.NextDouble()*(0.05+0)+0;

            this.Cost_per_good+= this.Cost_per_good * percentage_to_increase;
            Cost_per_good = Math.Round(Cost_per_good, 2); //100,xx

            Total_cost_of_the_batch_is_equal();
        }

        public int CompareTo(Goods? other)
        {
            if (this.Cost_per_good > other.Cost_per_good)
            {
                return 1;
            }
            else 
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return
                $"Cost per good: {this.Cost_per_good}$, " +
                $"Manufacturer: {this.Manufacturer}, " +
                $"Name: {this.Name}, " +
                $"Code: {this.Code}, " +
                $"Quantity in the batch of goods: {this.Quantity_in_the_batch} items, " +
                $"Total cost of the batchof goods: {this.Total_cost_of_the_batch}$.";
        }
    }
}