namespace OOP_Interfaces
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Bicycle myBicycle = new Bicycle();

            myCar.Move();
            myBicycle.Move();
        }
    }
}
