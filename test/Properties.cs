public class Properties(){
    public Int64 TeamSize{get;set;}
    public Int64 UnfairTeamSize{get;set;}
    public Int64 Team0Score{get;set;}
    public float TotalSecondsPlayed{get;set;}
    public Int64 MatchStartEpoch{get;set;}
    public Goal[] Goals{get;set;}
    public Highlight[] HighLights {get;set;}
    public PlayerStat[] PlayerStats {get;set;}
    public string ReplayName {get; set;}
    public Int64 ReplayVersion {get; set;}
    public Int64 ReplayLastSaveVersion {get; set;}
    public Int64 gameVersion {get; set;}
    public Int64 BuildID {get; set;}
    public Int64 Changelist {get;set;}
    public string BuildVersion{get;set;}
    public Int64 ReserveMegabytes{get;set;}
    public float RecordFPS{get;set;}
    public float KeyframeDelay{get;set;}
    public Int64 MaxChannels{get;set;}
    public Int64 MaxReplaySizeMB {get;set;}
    public string Id {get;set;}
    public string MapName {get;set;}
    public string Date {get;set;}
    public Int64 NumFrames {get;set;}
    public string MatchType {get; set;}
}