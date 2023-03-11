namespace Exercise_5
{
    internal class Program
    {
        struct Notebook
        {
            string model, manufacturer;
            decimal price;
            public Notebook(string model, decimal price, string manufacturer)
            {
                this.model = model;
                this.price = price;
                this.manufacturer = manufacturer;
            }
            public void Show()
            {
                Console.WriteLine("Model: {0}", model);
                Console.WriteLine("Manufacturer: {0}", manufacturer);
                Console.WriteLine("Cost: {0:C}", price);
            }
        }
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Kola",12,"Loka");
            notebook.Show();
            Console.ReadKey();
        }
    }
}