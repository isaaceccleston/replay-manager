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


int frameCount = 0;
foreach(Frame frame in replay.network_frames.Frames){
    frameCount++;
    System.Console.WriteLine($"\nFrame: {frameCount}, time: {frame.time}");
    System.Console.WriteLine("New Actors:");
    foreach(Actor actor in frame.GetReplicatedRBStates(frame.new_actors)){
        System.Console.WriteLine($"\tActorID: {actor.actor_id}, Object: {replay.GetNameFromObjectId(actor.object_id)}");
        System.Console.WriteLine("\t" + actor.attribute.RbToString());
    }
    System.Console.WriteLine("Updated Actors:");
    foreach(Actor actor in frame.GetReplicatedRBStates(frame.updated_actors)){
        System.Console.WriteLine($"\tActorID: {actor.actor_id}, Object: {replay.GetNameFromObjectId(actor.object_id)}");
        System.Console.WriteLine("\t" + actor.attribute.RbToString());
    }
}














































