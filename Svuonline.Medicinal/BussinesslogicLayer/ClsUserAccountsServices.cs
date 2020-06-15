using System.Linq;
using Svuonline.Medicinal.DataAccessLayer;
using Svuonline.Medicinal.BussinessObjectLayer;
using System.Windows.Forms;
using Svuonline.Medicinal.GenericCode;

namespace Svuonline.Medicinal.BussinesslogicLayer
{
    public static class ClsUserAccountsServices
    {
        static readonly IUserAccountsRepository Repository;
        public static bool UserNameAlreadyExists = false;
        public static bool EmailAlreadyExists = false;
        static ClsUserAccountsServices()
        {
            Repository = new ClsUserAccountsDataAccess();
        }
        public static UserAccount Insert(UserAccount UserAccountObj)
        {
            if(Repository.GetAll().Any(User => User.ScreenUserName == UserAccountObj.ScreenUserName))
            {
                UserNameAlreadyExists = true;
                return UserAccountObj;
            }
            else if (Repository.GetAll().Any(User => User.UserEmailAddress == UserAccountObj.UserEmailAddress))
            {
                EmailAlreadyExists = true;
                return UserAccountObj;
            }
            else
            {
            return Repository.Insert(UserAccountObj);
            }
        }
    }
}
