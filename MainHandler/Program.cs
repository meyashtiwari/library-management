using CoreLibrary;

namespace MainHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAndWrite ob = new ReadAndWrite();
            ob.msg();
            GetData ob1 = new GetData();
            ob1.msg();
            System.Console.ReadKey();
        }
    }
}
