using Factory;
using Factory.RealFactory;

public class Program
{
    public static void Main(string[] args)
    {
        // Створюємо фабрики для столів
        var partyTableFactory = new PartyTableFactory();
        var dinnerTableFactory = new DinnerTableFactory();
        var meetingTableFactory = new MeetingTableFactory();

        // Створюємо об'єкти типу Table, використовуючи фабрики
        var partyTable = partyTableFactory.CreateTable(10);
        var dinnerTable = dinnerTableFactory.CreateTable(6);
        var meetingTable = meetingTableFactory.CreateTable(4);

        // Сервіруємо столи
        var client = new TableClient();
        client.ServeTable(partyTableFactory, 10);
        client.ServeTable(dinnerTableFactory, 6);
        client.ServeTable(meetingTableFactory, 4);
    }
}