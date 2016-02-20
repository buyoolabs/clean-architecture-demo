using CleanArchitectureDemo.Domain.Gateways;
using CleanArchitectureDemo.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.UseCases.DeactivateProduct
{
    public class DeactivateProductInteractor
    {
        IProductRepository productRepository;
        INotificationSender notificationSender;

        public DeactivateProductInteractor(
            IProductRepository productRepository, 
            INotificationSender notificationSender)
        {
            this.productRepository = productRepository;
            this.notificationSender = notificationSender;
        }

        public void Execute(int productId)
        {
            var product = productRepository.GetById(productId);
            product.Deactivate();
            notificationSender.SendNotification();
        }
    }
}
