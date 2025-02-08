using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class PaymentsService : IPaymentsService
    {
        private readonly IRepository<Payment> _paymentRepository;

        public PaymentsService(IRepository<Payment> paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public Payment DeletePayment(Payment entity)
        {
            return _paymentRepository.Delete(entity);
        }

        public List<Payment> GetAllPayments()
        {
            return _paymentRepository.GetAll().ToList();
        }

        public Payment GetPayment(int? id)
        {
            return _paymentRepository.Get(id);
        }

      
        public Payment SavePayment(Payment payment)
        {
            if (payment == null)
            {
                throw new ArgumentNullException(nameof(payment), "Payment cannot be null");
            }

            payment.PaymentDate = DateTime.Now;  
            var savedPayment = _paymentRepository.Insert(payment); 

            return savedPayment;  
        }

      
        public List<Payment> InsertManyPayments(List<Payment> entities)
        {
            return _paymentRepository.InsertMany(entities);
        }

        public Payment InsertPayment(Payment entity)
        {
            return _paymentRepository.Insert(entity);
        }

        public Payment UpdatePayment(Payment entity)
        {
            return _paymentRepository.Update(entity);
        }
    }
}
