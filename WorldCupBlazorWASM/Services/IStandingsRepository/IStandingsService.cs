using WorldCupBlazorWASM.DTOS;

namespace WorldCupBlazorWASM.Services.IStandingsRepository;

public interface IStandingsService
{
    Task<StandingsResponseDto?> GetStandings();
    Task<MatchesResponseDto?> GetMatches();
}
