using System;
using System.Collections.Generic;

namespace JobBoards.Models
{
    public class JobBoard
    {
        // Job related variables
        public string JobTitle {get; set;}
        public string CompanyName {get; set;}
        public string JobDescription {get; set;}
        public string NameOfContactee {get; set;}
        public string ContactEmail {get; set;}
        public string ContactPhone {get; set;}
        public int Id { get; }

        private static List<JobBoard> _instances = new List<JobBoard>{};

        public JobBoard (string jobTitle, string companyName, string jobDescription, string nameOfContactee, string contactEmail, string contactPhone)
        {
            JobTitle = jobTitle;
            CompanyName = companyName;
            JobDescription = jobDescription;
            NameOfContactee = nameOfContactee;
            ContactEmail = contactEmail;
            ContactPhone = contactPhone;
            _instances.Add(this);
            Id = _instances.Count;
        }
        public static List<JobBoard> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}