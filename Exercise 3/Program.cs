namespace Exercise_3
{
    internal class Program
    {
        class MyClass
        {
            public string change;
        }
        struct MyStruct 
        {
            public string change;
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "first";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "first";
        }
        static void Main(string[] args)
        {

            MyClass myClass = new MyClass();
            myClass.change = "second";
            MyStruct myStruct = new MyStruct();
            myStruct.change = "second";
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            Console.ReadLine();
        }
    }
}