using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FormApp.Models
{
    public class CMRAFormModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime DatePMBOpened { get; set; }
        public string DatePMBClosed { get; set; }
        public string StreetAddressDelivery { get; set; }
        public string PMBNumber { get; set; }
        public string City { get; set; }
        public string UseType { get; set; } // Radio Button (Business/Residential)
        public string BusinessName { get; set; }
        public string BusinessType { get; set; }
        public string BusinessCity { get; set; }
        public string BusinessState { get; set; }
        public string BusinessZIP { get; set; }
        public string BusinessCountry { get; set; }

        // Store file paths instead of IFormFile
        public string PhotoIDPath { get; set; }
        public string AddressIDPath { get; set; }
        public string Form1583Path { get; set; }

        [NotMapped] // Exclude from database mapping
        public IFormFile PhotoID { get; set; } // For file upload handling only

        [NotMapped]
        public IFormFile AddressID { get; set; } // For file upload handling only

        [NotMapped]
        public IFormFile Form1583 { get; set; } // For file upload handling only
                                                // Binary data for storing files in the database
        public byte[] PhotoIDData { get; set; }
        public byte[] AddressIDData { get; set; }
        public byte[] Form1583Data { get; set; }

        // Metadata about the uploaded files
        public string PhotoIDFileName { get; set; }
        public string AddressIDFileName { get; set; }
        public string Form1583FileName { get; set; }

        public string PhotoIDContentType { get; set; }
        public string AddressIDContentType { get; set; }
        public string Form1583ContentType { get; set; }
    }




}
