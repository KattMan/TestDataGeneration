using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGenerationService.Entities;

namespace DataGenerationEntities
{
    public class PersonName : IPersonName 
    {
        public string Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Suffix { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Title, FirstName, MiddleName, LastName, Suffix);
        }
    }
}
