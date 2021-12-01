using System.ComponentModel.DataAnnotations;

namespace BugReportService.Models
{
    public class Report
    {
        private readonly DateTime _dateEntered = DateTime.Now;
        private static int _id = 1;

        public int Id
        {
            get { return _id; }
            set { _id = GenerateId(); }
        }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public bool IsResolved { get; set; }
        public DateTime DateEntered 
        {  
            set { DateEntered = DateTime.Now;}
        }

        public Report()
        {

        }

        public Report(string title, string description)
        {
            Title = title;
            Description = description;
        }

        /// <summary>
        /// Auto Increment the id for the Bug.Id
        /// </summary>
        /// <returns>
        /// Incremented Id
        /// </returns>
        static int GenerateId()
        {
            return _id++;
        }

    }
}
