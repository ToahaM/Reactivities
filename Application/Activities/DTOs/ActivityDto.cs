using System;
using Application.Profiles.DTOs;

namespace Application.Activities.DTOs;

public class ActivityDto
{
    public string Id {get; set;} = "";
    public string Title { get; set; } = "";
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = "";

    public bool IsCancelled { get; set; }
    public required string HostDisplayName { get; set; }
    public required string HostId { get; set; }
    

    // location props
    public string City { get; set; } = "";

    public string Venue { get; set; } = "";
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    
    // navigation properties

    public ICollection<UserProfile> Attendees { get; set; } = [];
}
