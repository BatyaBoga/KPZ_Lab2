using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    // Клас-клієнт, який використовує фабрики для створення столів
    public class TableClient
    {
        public void ServeTable(TableFactory factory, int numberOfSeats)
        {
            var table = factory.CreateTable(numberOfSeats);
            Console.WriteLine("Serving a {0} table for {1} guests with {2} tableware.", table.Purpose, table.NumberOfSeats, table.Tableware);
        }
    }
}
