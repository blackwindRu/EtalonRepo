using System;

namespace EtalonConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new EtalonBuilder();
            const int id = 10;
            var name = builder.GetEtalonNameById(id);

            Console.WriteLine(name);
        }
    }
}
