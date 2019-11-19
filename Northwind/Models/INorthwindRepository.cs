using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Models
{
    public interface INorthwindRepository
    {
        IQueryable<Category> Categories { get; }
        IQueryable<Product> Products { get; }
        IQueryable<Discount> Discounts { get; }
        IQueryable<Customer> Customers { get; }

        void AddCustomer(Customer customer);
        void EditCustomer(Customer customer);
        CartItem AddToCart(CartItemJSON cartItemJSON);
    }
}
