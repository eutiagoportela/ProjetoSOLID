using Projeto.LeilaoOnline.WebApp.Models;

namespace Projeto.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao : ICommand<Leilao>, IQuery<Leilao>
    {
    }
}
