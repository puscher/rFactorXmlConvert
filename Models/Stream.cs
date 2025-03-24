using System.Xml.Serialization;

namespace rFactorXmlConversation.Models;

[XmlRoot(ElementName="Stream")]
public class Stream { 

	[XmlElement(ElementName="Penalty")] 
	public List<Penalty> Penalty { get; set; } = new();

	[XmlElement(ElementName="Incident")] 
	public List<Incident> Incident { get; set; } = new();

	[XmlElement(ElementName="Sector")] 
	public List<Sector> Sector { get; set; } = new();

	[XmlElement(ElementName="Score")] 
	public List<Score> Score { get; set; } = new();
}
