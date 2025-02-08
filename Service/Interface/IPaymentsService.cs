using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IPaymentsService
    {
        List<Payment> GetAllPayments();
        Payment GetPayment(int? id);
        Payment InsertPayment(Payment entity);
        List<Payment> InsertManyPayments(List<Payment> entities);
        Payment UpdatePayment(Payment entity);
        Payment DeletePayment(Payment entity);
        Payment SavePayment(Payment payment);

    }
}
