// See https://aka.ms/new-console-template for more information
using MongoDB.Driver;
using MongoDB.Bson;

MongoClient client = new MongoClient("mongodb+srv://Rtic:WHBs01BDPjdGFxSh@cluster0.pcwslkt.mongodb.net/?retryWrites=true&w=majority");

// List<string> databases = client.ListDatabaseNames().ToList();

// foreach(string database in databases) {
//      Console.WriteLine(database);
// }

//* Add
var playlistCollection = client.GetDatabase("sample_mflix").GetCollection<Playlist>("playList");
// List<string> movieList = new List<string>();
// movieList.Add("Batman");
// movieList.Add("Spiderman");
// movieList.Add("Wonderwoman");
// playlistCollection.InsertOne(new Playlist("Janne", movieList));


//* Get
// var getCollection = client.GetDatabase("sample_mflix").GetCollection<Movie>("movies").AsQueryable();
// foreach (var document in getCollection)
// {
//     Console.WriteLine(document.title);
// }


//* Filter
//FilterDefinition<Playlist> filter = Builders<Playlist>.Filter.Eq("username", "nraboy");


//* Update
// UpdateDefinition<Playlist> update = Builders<Playlist>.Update.AddToSet<string>("username", "Mange");
// playlistCollection.UpdateOne(filter, update);

// List <Playlist> results = playlistCollection.Find(filter).ToList();

// foreach(Playlist result in results) {
//     Console.WriteLine(string.Join(", ", result));
// }

//playlistCollection.DeleteOne(filter);