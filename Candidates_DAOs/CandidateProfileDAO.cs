using Candidates_BusinessObject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Candidates_DAOs
{
    public class CandidateProfileDAO
    {
        private List<JobPosting> jobPostings;
        private List<CandidateProfile> candidateProfiles;
        private static CandidateProfileDAO instance;
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FileTxt/candidateProfiles.txt");
        private readonly string postingFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FileTxt/jobPostings.txt");

        public static CandidateProfileDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidateProfileDAO();
                }
                return instance;
            }
        }

        public CandidateProfileDAO()
        {
            candidateProfiles = new List<CandidateProfile>(); // Sửa kiểu danh sách
            jobPostings = LoadJobPostings();
            LoadDataFromFile();
        }

        private void LoadDataFromFile()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split('\t');
                    if (data.Length >= 6)
                    {
                        var candidateProfile = new CandidateProfile
                        {
                            CandidateId = data[0],
                            Fullname = data[1],
                            Birthday = DateTime.Parse(data[2]),
                            ProfileShortDescription = data[3],
                            ProfileUrl = data[4],
                            PostingId = data[5]
                        };
                        candidateProfiles.Add(candidateProfile);
                    }
                }
            }
        }

        private List<JobPosting> LoadJobPostings()
        {
            var postings = new List<JobPosting>();
            if (File.Exists(postingFilePath))
            {
                var lines = File.ReadAllLines(postingFilePath);
                foreach (var line in lines.Skip(1))
                {
                    var data = line.Split('\t');
                    if (data.Length >= 2)
                    {
                        var jobPosting = new JobPosting
                        {
                            PostingId = data[0],
                            JobPostingTitle = data[1]
                        };
                        postings.Add(jobPosting);
                    }
                }
            }
            return postings;
        }

        public CandidateProfile GetCandidateProfile(string id)
        {
            return candidateProfiles.SingleOrDefault(c => c.CandidateId.Equals(id));
        }

        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            if (GetCandidateProfile(candidateProfile.CandidateId) == null)
            {
                candidateProfiles.Add(candidateProfile);
                SaveDataToFile();
                return true;
            }
            return false;
        }

        public bool DeleteCandidateProfile(string candidateID)
        {
            var candidate = GetCandidateProfile(candidateID);
            if (candidate != null)
            {
                candidateProfiles.Remove(candidate);
                SaveDataToFile();
                return true;
            }
            return false;
        }

        public bool UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            var existingCandidate = GetCandidateProfile(candidateProfile.CandidateId);
            if (existingCandidate != null)
            {
                candidateProfiles.Remove(existingCandidate);
                candidateProfiles.Add(candidateProfile);
                SaveDataToFile();
                return true;
            }
            return false;
        }

        private void SaveDataToFile()
        {
            var lines = candidateProfiles.Select(cp => cp.ToString()); // Gọi ToString() cho mỗi đối tượng CandidateProfile
            File.WriteAllLines(filePath, lines);
        }

        public List<CandidateProfile> GetCandidatesWithPostings()
        {
            foreach (var candidate in candidateProfiles)
            {
                var posting = jobPostings.SingleOrDefault(p => p.PostingId == candidate.PostingId);
                candidate.Posting = posting;

                if (posting == null)
                {
                    Console.WriteLine($"No JobPosting found for CandidateId: {candidate.CandidateId} with PostingId: {candidate.PostingId}");
                }
            }
            return candidateProfiles; // Trả về danh sách các ứng viên đã gán JobPosting
        }
    }
}
