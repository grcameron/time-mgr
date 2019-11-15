# time-mgr
Just a small .net core / react app for monitoring how I spend my time at work. (also to learn react)

# mongodb stuff

basic stuff so far for mongodb:

use timeMgrDb

db.createCollection('TimeLogEntries')

db.TimeLogEntries.insertMany([{'Type':'Development','Description':'SD-xxxx','Start':'2016-05-18T16:00:00Z','End':'2016-05-18T17:00:00Z'}, {'Type':'UserExperience','Description':'SD-xxx1','Start':'2016-05-18T17:00:00Z','End':'2016-05-18T18:00:00Z'}])

# resources
https://docs.microsoft.com/en-us/aspnet/core/client-side/spa/react?view=aspnetcore-3.0&tabs=visual-studio
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-3.0&tabs=visual-studio-code
Add a CRUD operations service < here
https://docs.mongodb.com/manual/tutorial/install-mongodb-on-windows/#install-mdb-edition
