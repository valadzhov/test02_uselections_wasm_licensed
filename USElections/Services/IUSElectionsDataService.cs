using System.Reactive.Subjects;
using USElections.Models.USElectionsData;

namespace USElections.USElectionsData
{
    public interface IUSElectionsDataService
    {
        public BehaviorSubject<Candidate> RepublicanCandidate { get; }
        public BehaviorSubject<VoteCountResult> PopularVotesRepublican { get; }
        public BehaviorSubject<Candidate> DemocratCandidate { get; }
        public BehaviorSubject<VoteCountResult> ElectoralVotesDemocrat { get; }
        public BehaviorSubject<VoteCountResult> ElectoralVotesRepublican { get; }
        public BehaviorSubject<VoteCountResult> PopularVotesDemocrat { get; }

        Task<List<YearModel>> GetYearModelList();
        Task<List<VoteResult>> GetVoteResultList(int? year);
        Task<List<VoteResult>> GetVoteResultList1(int? year);
        Task<List<CandidateVoteResult>> GetCandidateVoteResultList(int? year);
        Task<List<StateVoteResult>> GetStateVoteResultList(int? year);
        Task<Candidate> GetCandidate(int? year);
        Task<VoteCountResult> GetVoteCountResult(int? year, string? party);
        Task<Candidate> GetCandidate1(int? year);
        Task<VoteCountResult> GetVoteCountResult1(int? year, string? party);
    }
}
