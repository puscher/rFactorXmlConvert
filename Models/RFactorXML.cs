using System.Xml.Serialization;

namespace rFactorXmlConversation.Models;

[XmlRoot(ElementName="rFactorXML")]
public class RFactorXML
{
	[XmlElement(ElementName = "RaceResults")]
	public RaceResults RaceResults { get; set; } = new();

	[XmlAttribute(AttributeName="version")] 
	public double Version { get; set; } 

	[XmlText] 
	public string Text { get; set; } = null!;
}
