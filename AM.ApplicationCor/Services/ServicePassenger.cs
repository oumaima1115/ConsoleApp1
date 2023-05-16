

using AM.ApplicationCor.Services;
using AM.ApplicationCor.Domain;
using AM.ApplicationCor.Interfaces;

namespace AM.ApplicationCor.Interfaces
{
    public class ServicePassenger : Service<Passenger>, IServicePassenger
    {
        public ServicePassenger(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
