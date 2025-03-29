using System.Runtime.InteropServices;
using Newtonsoft.Json;

//macOs path
string file = @"/Users/isaaceccleston/Documents/replay-manager/5860f1dd-bd16-4116-8d45-d3dd2250ffc6.json";
//windows path
//string file = @"C:\Users\gydre\Documents\RLTesting\test\5860f1dd-bd16-4116-8d45-d3dd2250ffc6.json";

Replay? replay = new Replay();

if (File.Exists(file)){
    string jsonStr = File.ReadAllText(file);
    replay = JsonConvert.DeserializeObject<Replay>(jsonStr);
}

foreach(long a in replay.GetObjectsOfActor(29)){
    System.Console.WriteLine(a);
}

foreach(Actor a in replay.GetAllActors()){
    System.Console.WriteLine(a);
}













































