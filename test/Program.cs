using System.Runtime.InteropServices;
using Newtonsoft.Json;

//macOs path
string file = @"/Users/isaaceccleston/Documents/replay-manager/5860f1dd-bd16-4116-8d45-d3dd2250ffc6.json";
// string file = @"/Users/isaaceccleston/Documents/replay-manager/24e76fa9-e0fd-4257-b139-ed8aa36c8e48.json";
//windows path
//string file = @"C:\Users\gydre\Documents\RLTesting\test\5860f1dd-bd16-4116-8d45-d3dd2250ffc6.json";
//string file = @"C:\Users\gydre\Documents\RLTesting\test\24e76fa9-e0fd-4257-b139-ed8aa36c8e48.json";
System.Console.WriteLine(file);

Replay? replay = new Replay();

if (File.Exists(file)){
    string jsonStr = File.ReadAllText(file);
    replay = JsonConvert.DeserializeObject<Replay>(jsonStr);
}

// int frameCount = 0;
// foreach(Frame frame in replay.network_frames.Frames){
//     frameCount++;
//     System.Console.WriteLine($"\nFrame: {frameCount}, time: {frame.time}");
//     System.Console.WriteLine("New Actors:");
//     foreach(Actor actor in frame.GetReplicatedRBStates(frame.new_actors)){
//         System.Console.WriteLine($"\tActorID: {actor.actor_id}, Object: {replay.GetNameFromObjectId(actor.object_id)}");
//         System.Console.WriteLine("\t" + actor.attribute.rigidBody);
//     }
//     System.Console.WriteLine("Updated Actors:");
//     foreach(Actor actor in frame.GetReplicatedRBStates(frame.updated_actors)){
//         System.Console.WriteLine($"\tActorID: {actor.actor_id}, Object: {replay.GetNameFromObjectId(actor.object_id)}");
//         System.Console.WriteLine("\t" + actor.attribute.rigidBody);
//     }
// }



//int eventHandlerId = 97;
int eventHandlerId = 228;
// finds all "shot/highlights" game registers as false events
foreach (Frame frame in replay.network_frames.Frames){
    foreach(Actor actor in frame.updated_actors){
        if(actor.object_id == eventHandlerId && actor.attribute.statEvent.object_id == -1){
            System.Console.WriteLine("\ntime: " + frame.time + "s");
            System.Console.WriteLine(actor.attribute.statEvent);
        }
    }
}












































