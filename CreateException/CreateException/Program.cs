using CreateException.Entities;
using CreateException.Entities.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            Resarvation reservation = new Resarvation(number, checkin, checkout);
            Console.WriteLine("Reservation" + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation:");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkin = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            checkout = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkin, checkout);
            Console.WriteLine("Resarvation " + reservation);
        }
        catch (DomainException e)
        {
            Console.WriteLine("Error in reservation: " + e.Message);
        }
        catch(FormatException e)
        {
            Console.WriteLine("Format error : " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected error: "+ e.Message);
        }

    }
}
