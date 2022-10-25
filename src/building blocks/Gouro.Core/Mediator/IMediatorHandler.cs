using FluentValidation.Results;
using Gouro.Core.Messages;
using System.Threading.Tasks;

namespace Gouro.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<ValidationResult> EnviarComando<T>(T comando) where T : Command;
    }
}
