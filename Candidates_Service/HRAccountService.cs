using Candidates_BusinessObject;
using Candidates_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates_Service
{
    public class HRAccountService : IHRAccountService
    {
        private IHRAccountRepo iAccountRepo;
        public HRAccountService()
        {
            iAccountRepo = new HRAccountRepo();
        }
        public Hraccount GetHraccountByEmail(string email)
        {
            return iAccountRepo.GetHraccountByEmail(email);
        }

        public List<Hraccount> GetHraccounts()
        {
            return iAccountRepo.GetHraccounts();
        }
    }
}
