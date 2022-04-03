using Hangman.Models;
using System.IO;
using System.Xml.Serialization;

namespace Hangman.Helps
{
    public class SerializationActions
    {
        public void SerializeUsers(string xmlFileName, Users entity)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(Users));
            FileStream fileStr = new FileStream(xmlFileName, FileMode.Create);
            xmlser.Serialize(fileStr, entity);
            fileStr.Dispose();
        }
        public Users DeserializeUsers(string xmlFileName)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(Users));
            FileStream file = new FileStream(xmlFileName, FileMode.Open);
            var entity = xmlser.Deserialize(file);
            file.Dispose();
            return entity as Users;
        }


        public void SerializeWords(string xmlFileName, Words entity)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(Words));
            FileStream fileStr = new FileStream(xmlFileName, FileMode.Create);
            xmlser.Serialize(fileStr, entity);
            fileStr.Dispose();
        }
        public Words DeserializeWords(string xmlFileName)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(Words));
            FileStream file = new FileStream(xmlFileName, FileMode.Open);
            var entity = xmlser.Deserialize(file);
            file.Dispose();
            return entity as Words;
        }

        public void SerializeImages(string xmlFileName, Images entity)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(Images));
            FileStream fileStr = new FileStream(xmlFileName, FileMode.Create);
            xmlser.Serialize(fileStr, entity);
            fileStr.Dispose();
        }
        public Images DeserializeImages(string xmlFileName)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(Images));
            FileStream file = new FileStream(xmlFileName, FileMode.Open);
            var entity = xmlser.Deserialize(file);
            file.Dispose();
            return entity as Images;
        }
    }
}
