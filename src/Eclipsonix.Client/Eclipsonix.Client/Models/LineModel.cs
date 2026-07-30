using System.Collections.Generic;

namespace Eclipsonix.Client.Models;

public class LineModel
{
    public enum Type
    {
        Empty,
        GameMode,
        Map,
        GameModeAndMap,
        TeamName,
        Score,
        TeamNameAndScore
    }
    
    public string GetFormattedType(Type type)
    {
        return type switch
        {
            Type.Empty => "Empty",
            Type.GameMode => "Game Mode",
            Type.Map => "Map",
            Type.GameModeAndMap => "Game Mode - Map",
            Type.TeamName => "Team Name",
            Type.Score => "Score",
            Type.TeamNameAndScore => "Team Name - Score",
            _ => "Empty" // '_`
        };
    }
    
    public List<string> formattedGetAllType()
    {
        return new List<string>()
        {
            "Empty",
            "Game Mode",
            "Map",
            "Game Mode - Map",
            "Team Name",
            "Score",
            "Team Name - Score"
        };
    }
    
}