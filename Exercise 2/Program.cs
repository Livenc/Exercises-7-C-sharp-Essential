namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Train[] trains = new Train[8] ;

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"{i+1} ");
                Console.Write("Enter train destination: ");
                trains[i].namelastdestination = Console.ReadLine();
                Console.Write("Enter train  number: ");
                trains[i].trainNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter train departure time: ");
                trains[i].time = Console.ReadLine();
                Console.WriteLine("-",12);
            }
            //Array.Sort(trains, (a, b) => a.namelastdestination.CompareTo(b.namelastdestination));
            
            trains = trains.OrderBy(x => x.trainNumber).ToArray() ;
            foreach (var item in trains)
            {
                Console.WriteLine(item.namelastdestination);
                Console.WriteLine(item.trainNumber);
                Console.WriteLine(item.time);
                Console.WriteLine("-",30);
            }
            Console.Write("Enter train number to search: ");
            int searchNumber = int.Parse(Console.ReadLine());

            bool found = false;
            foreach (Train train in trains)
            {
                if (train.trainNumber == searchNumber)
                {
                    Console.WriteLine($"Train {train.trainNumber} to {train.namelastdestination} departs at {train.time}.");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Train {searchNumber} not found.");
            }
            // Console.WriteLine(train.ToList());
            Console.ReadLine();
        }
    }
    struct Train
    {
        public string namelastdestination;
        public int trainNumber;
        public string time;
    }
}