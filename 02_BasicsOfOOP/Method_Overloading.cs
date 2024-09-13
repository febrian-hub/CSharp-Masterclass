using System;

namespace MethodOverloading
{
    internal class MedicalAppointment
    {
        private string _patientName;
        private DateTime _date;

        public MedicalAppointment(string patientName, DateTime date)
        {
            _patientName = patientName;
            _date = date;
        }

        public void Reschedule(DateTime date)
        {
            _date = date;
        }

        public void Reschedule(int month, int day)
        {
            _date = new DateTime(_date.Year, month, day);
        }
        public string PatientName
        {
            get { return _patientName; }
        }

        public DateTime Date
        {
            get { return _date; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var medicalAppointment = new MedicalAppointment("John Smith", new DateTime(2023, 4, 3));
            Console.WriteLine("Medical appointment created for " + medicalAppointment.PatientName + " on " + medicalAppointment.Date);

            // Reschedule using DateTime
            medicalAppointment.Reschedule(new DateTime(2023, 5, 10));
            Console.WriteLine("Rescheduled appointment to " + medicalAppointment.Date);

            // Reschedule using month and day
            medicalAppointment.Reschedule(6, 15);
            Console.WriteLine("Rescheduled appointment to " + medicalAppointment.Date);
        }
    }
}
