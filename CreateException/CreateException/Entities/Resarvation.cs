using System;
using CreateException.Entities.Exceptions;


namespace CreateException.Entities
{
    internal class Resarvation
    {
        public int Roomnumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Resarvation()
        {
        }
        public Resarvation(int roomnumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            Roomnumber = roomnumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update must be futures dates");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Room "
                + Roomnumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out"
                + CheckOut.ToString("dd/MM/yyyy")
                + ","
                + Duration()
                + " nights";
        }
    }
}
