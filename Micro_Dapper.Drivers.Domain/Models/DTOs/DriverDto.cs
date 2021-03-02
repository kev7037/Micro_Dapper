using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_Dapper.Drivers.Domain.Models.DTOs
{
    class DriverDto
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TypeTitle { get; set; }
    }
}
