using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nova.BusinessObjects;

namespace Nova.Controllers
{
    public interface IUserManager
    {
        List<CUser> getUserList();
        List<CUser> getAllUser();
        CUser getUserId(int iUserId);

        /// <summary>
        /// For user entry Form
        /// </summary>
        int addUser(CUser oCUser);
        int deleteUser(CUser oCUser);
        void updateUser(CUser oCUser);
        int updateUserList(List<CUser> lstUser);
    }
}
