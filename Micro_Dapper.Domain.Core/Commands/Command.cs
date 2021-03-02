using Micro_Dapper.Domain.Core.Events;
using System;

namespace Micro_Dapper.Domain.Core.Commands
{
    public abstract class Command: Message
    {
        protected Command() => Timestamp = DateTime.Now;

        public DateTime Timestamp { get; protected set; }

    }
}
