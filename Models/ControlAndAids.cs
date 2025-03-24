using System.Xml.Serialization;

namespace rFactorXmlConversation.Models;

[XmlRoot(ElementName="ControlAndAids")]
public class ControlAndAids { 

	[XmlAttribute(AttributeName="startLap")] 
	public int StartLap { get; set; } 

	[XmlAttribute(AttributeName="endLap")] 
	public int EndLap { get; set; } 

	[XmlText] 
	public string Text { get; set; } = null!;
}
