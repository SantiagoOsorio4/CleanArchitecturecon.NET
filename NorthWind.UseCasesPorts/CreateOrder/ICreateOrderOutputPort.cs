﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.UseCasesPorts.CreateOrder
{
    public interface ICreateOrderOutputPort
    {
        Task Handler(int orderId);
    }
}
