using BetweenSides.Context;
using BetweenSides.Models;
using System.Data;

namespace BetweenSides
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ApplicationDbContext context = new ApplicationDbContext();

            var lawyer = new Lawyer
            {
                Name = "Mr. Salem",
                LicenseNumber = "LAW12345",
                Specialization = "Criminal",
                Defendants = new List<Defendant>() 
            };
            context.Lawyers.Add(lawyer);
            context.SaveChanges();

            var defendant = new Defendant
            {
                Name = "Ali Al-Mansoori",
                NationalID = "987654321",
                Status = "Pending",
                Lawyer = lawyer 
            };
            context.Defendants.Add(defendant);
            context.SaveChanges();


            Console.WriteLine($"Lawyer: {lawyer.Name}, License: {lawyer.LicenseNumber}, Specialization: {lawyer.Specialization}");

            Console.WriteLine($"Defendant: {defendant.Name}, Status: {defendant.Status}");
            

        }
    }
}
