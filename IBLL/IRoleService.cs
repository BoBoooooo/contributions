﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
    public interface IRoleService : IBaseService<Role>
    {
        Role FindAuthByID(Guid ID);
        Role FindByRoleName(string RoleName);


    }
}
