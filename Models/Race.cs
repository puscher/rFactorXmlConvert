using System.Xml.Serialization;

namespace rFactorXmlConversation.Models;

[XmlRoot(ElementName="Race")]
public class Race { 

	[XmlElement(ElementName="DateTime")] 
	public int DateTime { get; set; }

	[XmlElement(ElementName = "TimeString")]
	public string TimeString { get; set; } = null!;

	[XmlElement(ElementName="Laps")] 
	public int Laps { get; set; } 

	[XmlElement(ElementName="Minutes")] 
	public int Minutes { get; set; }

	[XmlElement(ElementName = "Stream")] 
	public Stream Stream { get; set; } = new();

	[XmlElement(ElementName="FormationAndStart")] 
	public int FormationAndStart { get; set; } 

	[XmlElement(ElementName="MostLapsCompleted")] 
	public int MostLapsCompleted { get; set; } 

	[XmlElement(ElementName="Driver")] 
	public List<Driver> Driver { get; set; } = new();
}
