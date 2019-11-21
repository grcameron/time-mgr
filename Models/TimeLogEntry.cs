using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace time_mgrApi.Models
{
    public class TimeLogEntry
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }        
        //[BsonElement("Name")]  ** use this attrib if the element is referred to as something else in mongodb.
        public string Type { get; set; }
        public string Description { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}