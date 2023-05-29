﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category{ get; }
        IProductRepository Product{ get; }
        IShoppingCartRepository ShoppingCart{ get; }
        IApplicationUserRepository ApplicationUser{ get; }
        ICompanyRepository Company{ get; }
        IOrderDetailRepository OrderDetail{ get; }
        IOrderHeaderRepository OrderHeader{ get; }
        void Save();
    }
}
