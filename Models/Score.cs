using System.Xml.Serialization;

namespace rFactorXmlConversation.Models;

[XmlRoot(ElementName="Score")]
public class Score { 

	[XmlAttribute(AttributeName="et")] 
	public string Et { get; set; } = null!;

	[XmlText] 
	public string Text { get; set; } = null!;
}
