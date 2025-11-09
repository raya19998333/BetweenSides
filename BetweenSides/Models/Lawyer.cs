using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenSides.Models
{
    public class Lawyer
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
        public string Specialization { get; set; }
     
     

        // 🔗 Navigation property
        public ICollection<Defendant> Defendants { get; set; }
        public Lawyer() { }


       

        public void SendMessage(string message, Defendant defendant)
        {
            Console.WriteLine($"Message to {defendant.Name}: {message}");
        }



    }
}
