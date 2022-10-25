using System;
using System.Threading.Tasks;
using Gouro.Core.Messages.Integration;
using Gouro.Pagamentos.API.Models;

namespace Gouro.Pagamentos.API.Services
{
    public interface IPagamentoService
    {
        Task<ResponseMessage> AutorizarPagamento(Pagamento pagamento);
        Task<ResponseMessage> CapturarPagamento(Guid pedidoId);
        Task<ResponseMessage> CancelarPagamento(Guid pedidoId);
    }
}