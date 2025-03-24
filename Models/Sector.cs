using System.Xml.Serialization;

namespace rFactorXmlConversation.Models;

[XmlRoot(ElementName="Sector")]
public class Sector { 

	[XmlAttribute(AttributeName="et")] 
	public string Et { get; set; } = null!;

	[XmlText]
	public string Text { get; set; } = null!;
}
