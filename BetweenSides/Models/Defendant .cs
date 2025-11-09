using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenSides.Models
{
    public class Defendant
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationalID { get; set; }
        public string CaseId { get; set; }
        public string Status { get; set; }
        // 🔗 Foreign Key إلى المحامي
        public int LawyerId { get; set; }

        [ForeignKey("LawyerId")]
        public Lawyer Lawyer { get; set; }

        public Defendant()
        {
            
        }


        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Received message: {message}");
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
        }
    }
}
