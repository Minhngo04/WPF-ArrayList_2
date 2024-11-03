using Candidates_BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates_Service
{
    public interface ICandidateProfileService
    {
        public List<CandidateProfile> GetCandidatesWithPostings();
        public CandidateProfile GetCandidateProfile(string id);

        public bool addCandidateProfile(CandidateProfile candidateProfile);

        public bool deleteCandidateProfile(string candidateID);
        public bool updateCandidateProfile(CandidateProfile candidateProfile);
    }
}
