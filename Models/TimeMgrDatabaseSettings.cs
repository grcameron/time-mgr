namespace time_mgrApi.Models
{
    public class TimeMgrDatabaseSettings : ITimeMgrDatabaseSettings
    {
        public string TimeLogEntriesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ITimeMgrDatabaseSettings
    {
        string TimeLogEntriesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}