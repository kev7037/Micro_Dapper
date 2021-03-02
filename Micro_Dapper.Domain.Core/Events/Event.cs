using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_Dapper.Domain.Core.Events
{
    public abstract class Event
    {
        protected Event() => Timestamp = DateTime.Now;

        public DateTime Timestamp { get; protected set; }


    }
}
