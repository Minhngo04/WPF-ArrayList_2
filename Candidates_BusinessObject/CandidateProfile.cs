using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates_BusinessObject
{
    public partial class CandidateProfile
    {
        public string CandidateId { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public DateTime? Birthday { get; set; }
        public string? ProfileShortDescription { get; set; }
        public string? ProfileUrl { get; set; }
        public string? PostingId { get; set; }

        public virtual JobPosting? Posting { get; set; }

        public override string ToString()
        {
            return $"{CandidateId}\t{Fullname}\t{Birthday:yyyy-MM-dd HH:mm:ss.fff}\t{ProfileShortDescription}\t{ProfileUrl}\t{PostingId}";
        }
    }
}
