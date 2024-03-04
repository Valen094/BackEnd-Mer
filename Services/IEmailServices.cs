using MC_BackEnd.Models;

namespace MC_BackEnd.Services
{
    public interface IEmailServices
    {
        void SendEmail(EmailDTO request);
    }
}
