namespace Factory.RealFactory
{
    // Конкретна фабрика для створення столів для переговорів
    public class MeetingTableFactory : TableFactory
    {
        public override Table CreateTable(int numberOfSeats)
        {
            var table = new Table
            {
                NumberOfSeats = numberOfSeats,
                Purpose = "Meeting",
                Tableware = "Reusable"
            };
            return table;
        }
    }
}
