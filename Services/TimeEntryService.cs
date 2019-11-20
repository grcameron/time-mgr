using time_mgrApi.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace time_mgrApi.Services
{
    public class TimeEntryService
    {
        private readonly IMongoCollection<TimeLogEntry> _timeEntries;

        public TimeEntryService(ITimeMgrDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _timeEntries = database.GetCollection<TimeLogEntry>(settings.TimeLogEntriesCollectionName);
        }

        public List<TimeLogEntry> Get() =>
            _timeEntries.Find(log => true).ToList();

        public TimeLogEntry Get(string id) =>
            _timeEntries.Find<TimeLogEntry>(log => log.Id == id).FirstOrDefault();

        public TimeLogEntry Create(TimeLogEntry log)
        {
            _timeEntries.InsertOne(log);
            return log;
        }

        public void Update(string id, TimeLogEntry timeLogIn) =>
            _timeEntries.ReplaceOne(log => log.Id == id, timeLogIn);

        public void Remove(TimeLogEntry timeLogIn) =>
            _timeEntries.DeleteOne(log => log.Id == timeLogIn.Id);

        public void Remove(string id) => 
            _timeEntries.DeleteOne(log => log.Id == id);
    }
}