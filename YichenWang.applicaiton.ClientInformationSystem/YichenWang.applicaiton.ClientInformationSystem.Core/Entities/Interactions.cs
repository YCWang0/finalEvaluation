using System;
using System.Collections.Generic;
using System.Text;

namespace YichenWang.applicaiton.ClientInformationSystem.Core.Entities
{
    public class Interactions
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmpId { get; set; }
        public string IntType { get; set; }
        public DateTime IntDate { get; set; }
        public string Remarks { get; set; }

        public ICollection<Employees> Employees {get;set;}
        public ICollection<Clients> Clients { get; set; }
    }
}
