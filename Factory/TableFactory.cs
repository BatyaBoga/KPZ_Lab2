
namespace Factory
{
    // Абстрактний клас для фабрики столів
    public abstract class TableFactory
    {
        public abstract Table CreateTable(int numberOfSeats);
    }
}
