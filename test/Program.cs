using Newtonsoft.Json;

string file = @"C:\Users\gydre\Documents\RLTesting\test\5860f1dd-bd16-4116-8d45-d3dd2250ffc6.json";
Replay replay = new Replay();

if (File.Exists(file)){
    string jsonStr = File.ReadAllText(file);
    replay = JsonConvert.DeserializeObject<Replay>(jsonStr);
}

List<Int64> ints = new List<Int64>();

// // track player through time
// foreach (Frame frame in replay.network_frames.Frames){
//     foreach(Actor actor in frame.updated_actors){
//         if(actor.object_id == 57){
//             System.Console.WriteLine($"\ntime: {frame.time}");
//             if(ints.Contains(actor.actor_id)){
//                 break;
//             }else{
//                 ints.Add(actor.actor_id);
//             }
//         }
//     }
// }

// foreach(var x in ints){
//     System.Console.WriteLine(x);
// }

// int actorID = 36;
// List<Int64> objects = new List<Int64>();

// foreach(Frame frame in replay.network_frames.Frames){
//     foreach(Actor actor in  frame.new_actors){
//         if(actor.actor_id == actorID){
//             if(!objects.Contains(actor.object_id)){
//                 objects.Add(actor.object_id);
//             }
//         }
//     }
//     foreach(Actor actor in  frame.updated_actors){
//         if(actor.actor_id == actorID){
//             if(!objects.Contains(actor.object_id)){
//                 objects.Add(actor.object_id);
//             }
//         }
//     }
// }

// foreach (Int64 x in objects)
// {
//     System.Console.WriteLine(x);
// }


foreach(Frame frame in replay.network_frames.Frames){
    foreach(Actor actor in frame.updated_actors){
        if(actor.actor_id == 29){
            System.Console.WriteLine($"\ntime: {frame.time}");
            System.Console.WriteLine($"ActorID: {actor.actor_id}");
            System.Console.WriteLine($"Object: {replay.nameFromObjectId(actor.object_id)}");
            System.Console.WriteLine(actor.attribute.ToString());
        }
    }
}

public class Replay(){
    public Int64 header_size {get; set;}
    public Int64 header_crc {get; set;} 
    public Int64 major_version {get; set;}
    public Int64 minor_version {get; set;}
    public Int64 net_version {get; set;}
    public string game_type {get; set;}
    public Properties properties {get; set;}
    public Int64 content_size {get; set;}
    public Int64 content_crc {get; set;}
    public NetworkFrames network_frames {get; set;}

    public string[] levels{get;set;}

    public Keyframe[] keyframes{get;set;}

    public Debug[] debug_info{get;set;}

    public TickMark[] tick_marks{get;set;}

    public string[] packages{get;set;}

    public string[] objects{get;set;}

    public string[] names{get;set;}

    public ClassIndex[] class_indices{get;set;}

    public string nameFromObjectId(Int64 objectIndex){
        return this.objects[objectIndex];
    }
}

public class ClassIndex(){
    public string className{get;set;}
    public Int64 index{get;set;}
}

public class TickMark(){
    public string description{get;set;}
    public Int64 frame{get;set;}
}

public class Debug(){
    public Int64 frame{get;set;}
    public string user{get;set;}
    public string text{get;set;}
}

public class Keyframe(){
    public float time{get;set;}
    public float frame{get;set;}
    public float position{get;set;}
}

public class Properties(){
    public Int64 TeamSize{get;set;}
    public Int64 UnfairTeamSize{get;set;}
    public Int64 Team0Score{get;set;}
    public float TotalSecondsPlayed{get;set;}
    public Int64 MatchStartEpoch{get;set;}
    public Goal[] Goals{get;set;}
    public Highlight[] HighLights {get;set;}
    public PlayerStat[] PlayerStats {get;set;}
    public string ReplayName {get; set;}
    public Int64 ReplayVersion {get; set;}
    public Int64 ReplayLastSaveVersion {get; set;}
    public Int64 gameVersion {get; set;}
    public Int64 BuildID {get; set;}
    public Int64 Changelist {get;set;}
    public string BuildVersion{get;set;}
    public Int64 ReserveMegabytes{get;set;}
    public float RecordFPS{get;set;}
    public float KeyframeDelay{get;set;}
    public Int64 MaxChannels{get;set;}
    public Int64 MaxReplaySizeMB {get;set;}
    public string Id {get;set;}
    public string MapName {get;set;}
    public string Date {get;set;}
    public Int64 NumFrames {get;set;}
    public string MatchType {get; set;}
}

public class Goal(){
    public Int64 frame{get;set;}
    public string PlayerName{get;set;}
    public int PlayerTeam{get;set;}
}

public class Highlight(){
    public Int64 frame{get;set;}
    public string CarName{get;set;}
    public string BallName{get;set;}
    public string GoalActorName{get;set;}
}

public class PlayerStat(){
    public PlayerID PlayerID{get;set;}
    public string Name {get;set;}
    public Platform platform{get;set;}
    public Int64 OnlineID{get;set;}
    public Int64 Team{get;set;}
    public Int64 Score{get;set;}
    public Int64 Goals{get;set;}
    public Int64 Assists{get;set;}
    public Int64 Saves{get;set;}
    public Int64 Shots{get;set;}
    public bool bBot{get;set;}
}

public class Platform(){
    public string kind{get;set;}
    public string value{get;set;}
}

public class PlayerID(){
    public string name{get;set;}
    public Fields fields{get;set;}
}

public class Fields(){
    public Int64 Uid{get;set;}
    public NpId NpId{get;set;}
    public Handle handle{get;set;}
    public string Data{get;set;}
    public string Opt{get;set;}
    public string Reserved{get;set;}
    public string EpicAccountId{get;set;}
    public Platform platform{get;set;}
}

public class NpId(){
    public string name{get;set;}
    public Fields fields{get;set;}
}

public class Handle(){
    public string name{get;set;}
    public Fields fields{get;set;}
}

public class NetworkFrames(){
    public Frame[] Frames{get;set;}
}

public class Frame(){
    public float time{get;set;}
    public float delta{get;set;}
    public Actor[] new_actors{get;set;}
    public int[] deleted_actors{get;set;}
    public Actor[] updated_actors{get;set;}
    // public Actor[] deleted_actors{get;set;}

    public override string ToString()
    {
        string str = "";
        str += "\nNew actors:";
        foreach(Actor x in new_actors){
            str += $"\n{x.ToString()}";
        }
        str += "\nDeleted actors:";
        str += $"\n{deleted_actors.ToString()}";
        
        str += "\nUpdated actors:";
        foreach(Actor x in updated_actors){
            str += $"\n{x.ToString()}";
        }
       
        return str;
    }

}

public class Actor(){
    public Int64 actor_id{get;set;}
    public Int64 name_id{get;set;}
    public Int64 object_id{get;set;}
    public Trajectory initial_trajectory{get;set;}
    public Attribute attribute{get;set;}
    //do i need to kkeep doing this it runs??

    public override string ToString()
    {
        return $"ActorID: {actor_id}, Object: {object_id}\nAttributes: {attribute.ToString()}";
    }
}

public class Attribute(){
    public RigidBody rigidBody{get;set;}
    public Int64 Byte{get;set;}
    public Int64 Int{get;set;}
    public float Float{get;set;}
    public ActiveActor activeActor{get;set;}
    public string String{get;set;}
    public bool Boolean{get;set;}

    public override string ToString()
    {
        if(rigidBody != null){
            return $"RigidBody: {rigidBody.ToString()}";
        }else{
            return "";
        }
        
    }

}

public class ActiveActor(){
    public bool active{get;set;}
    public int actor{get;set;}
}
public class RigidBody(){
    public bool sleeping{get;set;}
    public String3 location{get;set;}
    public String4 rotation{get;set;}
    public String3 linear_velocity{get;set;}
    public String3 angular_velocity{get;set;}

    public override string ToString()
    {
        // return $"\nlocation: {location.ToString()}\nrotation: {rotation.ToString()}\nlinearVel: {linear_velocity.ToString()}\nangularVel: {angular_velocity.ToString()}";
        return $"\nlocation: {location.ToString()}\nrotation: {rotation.ToString()}";
    }
}

public class String3(){
    public string x{get;set;}
    public string y{get;set;}
    public string z{get;set;}

    public override string ToString()
    {
        return $"x:{x}, y:{y}, z:{z}";
    }
}

public class String4(){
    public string x{get;set;}
    public string y{get;set;}
    public string z{get;set;}
    public string w{get;set;}

    public override string ToString()
    {
        return $"x:{x}, y:{y}, z:{z}, w:{w}";
    }
}

public class Trajectory(){
    public String3 location{get;set;}
    public Rotation rotation{get;set;}
}

public class Rotation(){
    public string yaw{get;set;}
    public string pitch{get;set;}
    public string roll{get;set;}
}