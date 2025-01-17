﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Models;
namespace Core.DataAccess.Data.Repository.IRepository
{
    public interface IOrderHeaderRepository: IRepository<OrderHeader>
    {
        public void ChangeOrderStatus(int orderHeaderId, string status);
    }
}
