using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_Dapper.Domain.Core.Events
{
    public abstract class Message: IRequest<bool>
    {
        protected Message() => MessageType = GetType().Name;
        public string MessageType { get; protected set; }
    }
}