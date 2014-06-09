using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.WebData;

namespace LeaveManagementSystem.Models
{
    public class UserAccountModel : ExtendedMembershipProvider
    {
        public override bool ValidateUser(string username, string password)
        {
            
            throw new NotImplementedException();
        }

        
        
    }

    public class RoleProvider : SimpleRoleProvider
    {

    }
}