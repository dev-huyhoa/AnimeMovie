﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Shared.ViewModels;

namespace MovieData.Interfaces
{
    public interface IRole
    {
        Task<Response> GetsRole();
        Response SaveRole();
    }
}
