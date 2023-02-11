namespace Factory.RealFactory
{
    // Конкретна фабрика для створення столів для вечірок
    public class PartyTableFactory : TableFactory
    {
        public override Table CreateTable(int numberOfSeats)
        {
            var table = new Table
            {
                NumberOfSeats = numberOfSeats,
                Purpose = "Party",
                Tableware = "Disposable"
            };
            return table;
        }
    }
}
