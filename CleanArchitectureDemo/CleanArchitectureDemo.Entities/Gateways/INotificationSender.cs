using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Gateways
{
    public interface INotificationSender
    {
        void SendNotification();
    }
}
