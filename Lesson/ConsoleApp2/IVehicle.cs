namespace ConsoleApp2
{
    public interface IVehicle
    {
        string Name { get; }

        int GetSpeed();

        void PrintInfo();
    }
}