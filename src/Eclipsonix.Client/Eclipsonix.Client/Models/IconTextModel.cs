using System.Collections.Generic;

namespace Eclipsonix.Client.Models;

public class IconTextModel
{
    public enum Type
    {
        Empty,
        ApplicationName,
        MapName,
        TeamName
    }

    public string GetFormattedType(Type type)
    {
        return type switch
        {
            Type.Empty => "Empty",
            Type.ApplicationName => "Application Name",
            Type.MapName => "Map Name",
            Type.TeamName => "Team Name",
            _ => "Empty" // '_`
        };
    }

    public List<string> FormattedGetAllType()
    {
        return new List<string>
        {
            "Empty",
            "Application Name",
            "Map Name",
            "Team Name"
        };
    }
}