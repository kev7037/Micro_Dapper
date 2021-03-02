using Micro_Dapper.Domain.Core.Events;
using System.Threading.Tasks;

namespace Micro_Dapper.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHanlder
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHanlder {}

}