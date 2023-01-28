namespace WorldCupBlazorWASM.DTOS;

public class MatchDto
{
    public DateTime UtcDate { get; set; }
    public string Status { get; set;}
    public string Group { get; set;}
    public TeamDto HomeTeam { get; set;}
    public TeamDto AwayTeam { get; set;}
    public ScoreDto Score { get; set;}
}
