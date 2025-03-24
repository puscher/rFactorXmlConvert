using System.Xml.Serialization;

namespace rFactorXmlConversation.Models;

[XmlRoot(ElementName="Lap")]
public class Lap { 

	[XmlAttribute(AttributeName="num")] 
	public int Num { get; set; } 

	[XmlAttribute(AttributeName="p")] 
	public int P { get; set; } 

	[XmlAttribute(AttributeName="et")] 
	public double Et { get; set; } 

	[XmlAttribute(AttributeName="s1")] 
	public double S1 { get; set; } 

	[XmlAttribute(AttributeName="s2")] 
	public double S2 { get; set; } 

	[XmlAttribute(AttributeName="s3")] 
	public double S3 { get; set; } 

	[XmlAttribute(AttributeName="topspeed")] 
	public double Topspeed { get; set; } 

	[XmlAttribute(AttributeName="fcompound")] 
	public string Fcompound { get; set; } = null!;

	[XmlAttribute(AttributeName="rcompound")] 
	public string Rcompound { get; set; } = null!;

	[XmlText] 
	public string Text { get; set; } = null!;

	[XmlAttribute(AttributeName="pit")] 
	public int Pit { get; set; } 
}
