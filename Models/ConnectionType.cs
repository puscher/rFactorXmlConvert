using System.Xml.Serialization;

namespace rFactorXmlConversation.Models;

[XmlRoot(ElementName="ConnectionType")]
public class ConnectionType { 

	[XmlAttribute(AttributeName="upload")] 
	public int Upload { get; set; } 

	[XmlAttribute(AttributeName="download")] 
	public int Download { get; set; } 

	[XmlText] 
	public string Text { get; set; } = null!;
}
