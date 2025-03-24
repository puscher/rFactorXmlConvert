using System.Xml.Serialization;

namespace rFactorXmlConversation;

public class XmlHelper
{
    public static T DeserializeXmlFile<T>(string filePath) where T : class
    {
        try
        {
            using var stream = new FileStream(filePath, FileMode.Open);
            var serializer = new XmlSerializer(typeof(T));
            return serializer.Deserialize(stream) as T;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading XML file: {ex.Message}");
            return null;
        }
    }
}