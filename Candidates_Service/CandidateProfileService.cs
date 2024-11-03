using Candidates_BusinessObject;
using Candidates_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates_Service
{
    public class CandidateProfileService : ICandidateProfileService
    {
        private readonly ICandidateProfileRepo profileRepo;

        public CandidateProfileService()
        {
            profileRepo = new CandidateProfileRepo();
        }

        public bool addCandidateProfile(CandidateProfile candidateProfile)
        {
            return profileRepo.addCandidateProfile(candidateProfile);
        }

        public bool deleteCandidateProfile(string candidateID)

        {
            return profileRepo.deleteCandidateProfile(candidateID);
        }

        public CandidateProfile GetCandidateProfile(string id)
        {
            return profileRepo.GetCandidateProfile(id);
        }
        public List<CandidateProfile> GetCandidatesWithPostings()
        {
            return profileRepo.GetCandidatesWithPostings();
        }

        public bool updateCandidateProfile(CandidateProfile candidateProfile)
        {
            return profileRepo.updateCandidateProfile(candidateProfile);
        }
    }
}
