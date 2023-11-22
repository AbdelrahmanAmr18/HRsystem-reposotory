
using HRsystem_DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRsystem_Domain.Repositories
{
    public interface IAuthService<T> where T : ApplicationUser
    {
       string GenerateToken(ApplicationUser user);

    }
}
