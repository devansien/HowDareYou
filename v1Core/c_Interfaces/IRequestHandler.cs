using System.Threading.Tasks;

namespace HowDareYou
{
    interface IRequestHandler
    {
        Task HandleRequest();
    }
}
