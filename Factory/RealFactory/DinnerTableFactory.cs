namespace Factory.RealFactory
{
    // Конкретна фабрика для створення столів для обідів
    public class DinnerTableFactory : TableFactory
    {
        public override Table CreateTable(int numberOfSeats)
        {
            var table = new Table
            {
                NumberOfSeats = numberOfSeats,
                Purpose = "Dinner",
                Tableware = "Reusable"
            };
            return table;
        }
    }
}
