using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Part_01.src
{
    public class OrderProcessor
    {
        private readonly IOrderRepositry _repo;
        private readonly IEmailSender _email;
        public OrderProcessor(IOrderRepositry repo , IEmailSender email)
        {
            _repo = repo;
            _email = email;

        }
        public void Process(int orderId, string customerEmail)
        {
            _repo.Save(orderId ,DateTime.Now);
            _email.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
        }
    }

}
