using System.Net.Http.Json;
using WorldCupBlazorWASM.DTOS;

namespace WorldCupBlazorWASM.Services.IStandingsRepository;

public class StandingsService : IStandingsService
{
    private readonly HttpClient HttpClient;
    private readonly string BaseUrl = "https://api.football-data.org/v4";
    public StandingsService(HttpClient httpClient)
    {
        HttpClient = httpClient;
        HttpClient.DefaultRequestHeaders.Add("X-Auth-Token", "fd539734ff7b463999c6547d73637e5a");
    }

    public async Task<StandingsResponseDto> GetStandings()
    {
        return await HttpClient.GetFromJsonAsync<StandingsResponseDto>($"{BaseUrl}/competitions/WC/standings");
    }
}
