using System.Xml.Serialization;

namespace rFactorXmlConversation.Models;

[XmlRoot(ElementName="Incident")]
public class Incident { 

	[XmlAttribute(AttributeName="et")] 
	public string Et { get; set; }  = null!;

	[XmlText] 
	public string Text { get; set; } = null!;
}
