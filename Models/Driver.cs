using System.Xml.Serialization;

namespace rFactorXmlConversation.Models;

[XmlRoot(ElementName="Driver")]
public class Driver { 

	[XmlElement(ElementName="Name")] 
	public string Name { get; set; } = null!;

	[XmlElement(ElementName="Connected")] 
	public int Connected { get; set; } 

	[XmlElement(ElementName="VehFile")] 
	public string VehFile { get; set; } = null!;

	[XmlElement(ElementName="UpgradeCode")] 
	public string UpgradeCode { get; set; } = null!;

	[XmlElement(ElementName="VehName")] 
	public string VehName { get; set; } = null!;

	[XmlElement(ElementName="Category")] 
	public string Category { get; set; } = null!;

	[XmlElement(ElementName="CarType")] 
	public string CarType { get; set; } = null!;

	[XmlElement(ElementName="CarClass")] 
	public string CarClass { get; set; } = null!;

	[XmlElement(ElementName="CarNumber")] 
	public int CarNumber { get; set; } 

	[XmlElement(ElementName="TeamName")] 
	public string TeamName { get; set; } = null!;

	[XmlElement(ElementName="isPlayer")] 
	public int IsPlayer { get; set; } 

	[XmlElement(ElementName="ServerScored")] 
	public int ServerScored { get; set; } 

	[XmlElement(ElementName="GridPos")] 
	public int GridPos { get; set; } 

	[XmlElement(ElementName="Position")] 
	public int Position { get; set; } 

	[XmlElement(ElementName="ClassGridPos")] 
	public int ClassGridPos { get; set; } 

	[XmlElement(ElementName="ClassPosition")] 
	public int ClassPosition { get; set; } 

	[XmlElement(ElementName="LapRankIncludingDiscos")] 
	public int LapRankIncludingDiscos { get; set; }

	[XmlElement(ElementName = "Lap")]
	public List<Lap> Lap { get; set; } = new();

	[XmlElement(ElementName="BestLapTime")] 
	public double BestLapTime { get; set; } 

	[XmlElement(ElementName="FinishTime")] 
	public double FinishTime { get; set; } 

	[XmlElement(ElementName="Laps")] 
	public int Laps { get; set; } 

	[XmlElement(ElementName="Pitstops")] 
	public int Pitstops { get; set; } 

	[XmlElement(ElementName="FinishStatus")] 
	public string FinishStatus { get; set; } = null!;

	[XmlElement(ElementName = "ControlAndAids")]
	public ControlAndAids ControlAndAids { get; set; } = new();

	[XmlElement(ElementName="DNFReason")] 
	public string DnfReason { get; set; } = null!;
}
