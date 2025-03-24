using System.Xml.Serialization;

namespace rFactorXmlConversation.Models;

[XmlRoot(ElementName = "RaceResults")]
public class RaceResults
{
    [XmlElement(ElementName = "Setting")] 
    public string Setting { get; set; } = null!;

    [XmlElement(ElementName = "ServerName")]
    public string ServerName { get; set; } = null!;

    [XmlElement(ElementName = "ClientFuelVisible")]
    public int ClientFuelVisible { get; set; }

    [XmlElement(ElementName = "PlayerFile")]
    public string PlayerFile { get; set; } = null!;

    [XmlElement(ElementName = "DateTime")] 
    public int DateTime { get; set; }

    [XmlElement(ElementName = "TimeString")]
    public string TimeString { get; set; } = null!;

    [XmlElement(ElementName = "TrackVenue")]
    public string TrackVenue { get; set; } = null!;

    [XmlElement(ElementName = "TrackCourse")]
    public string TrackCourse { get; set; } = null!;

    [XmlElement(ElementName = "TrackEvent")]
    public string TrackEvent { get; set; } = null!;

    [XmlElement(ElementName = "TrackLength")]
    public string TrackLength { get; set; } = null!;

    [XmlElement(ElementName = "GameVersion")]
    public double GameVersion { get; set; }

    [XmlElement(ElementName = "Dedicated")]
    public int Dedicated { get; set; }

    [XmlElement(ElementName = "ConnectionType")]
    public ConnectionType ConnectionType { get; set; } = new();

    [XmlElement(ElementName = "RaceLaps")] 
    public int RaceLaps { get; set; }

    [XmlElement(ElementName = "RaceTime")] 
    public int RaceTime { get; set; }

    [XmlElement(ElementName = "MechFailRate")]
    public int MechFailRate { get; set; }

    [XmlElement(ElementName = "DamageMult")]
    public int DamageMult { get; set; }

    [XmlElement(ElementName = "FuelMult")] 
    public int FuelMult { get; set; }

    [XmlElement(ElementName = "TireMult")] 
    public int TireMult { get; set; }

    [XmlElement(ElementName = "VehiclesAllowed")]
    public string VehiclesAllowed { get; set; } = null!;

    [XmlElement(ElementName = "ParcFerme")]
    public int ParcFerme { get; set; }

    [XmlElement(ElementName = "FixedSetups")]
    public int FixedSetups { get; set; }

    [XmlElement(ElementName = "FreeSettings")]
    public int FreeSettings { get; set; }

    [XmlElement(ElementName = "FixedUpgrades")]
    public int FixedUpgrades { get; set; }

    [XmlElement(ElementName = "LimitedTires")]
    public int LimitedTires { get; set; }

    [XmlElement(ElementName = "Race")] 
    public Race Race { get; set; } = new();
}