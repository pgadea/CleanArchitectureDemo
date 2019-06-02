using CleanArchitecture.Domain.Core.Commands;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
