using AM.ApplicationCor.Services;
using AM.ApplicationCor.Interfaces;
using AM.ApplicationCor.Domain;

namespace AM.ApplicationCore.Interfaces
{
    public class ServiceTicket : Service<Ticket>, IServiceTicket
    {
        public ServiceTicket(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
