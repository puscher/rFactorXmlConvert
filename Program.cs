// See https://aka.ms/new-console-template for more information

using rFactorXmlConversation;
using rFactorXmlConversation.Models;

var filePath = ".\\2024_12_12_20_56_57-81R1.xml";

var raceData = XmlHelper.DeserializeXmlFile<RFactorXML>(filePath);

Console.WriteLine(filePath);
