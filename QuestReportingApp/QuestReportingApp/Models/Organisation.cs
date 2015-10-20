using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestReportingApp.Models
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type  { get; set; }
        public string ContactName { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public int Postcode { get; set; }
    }
}