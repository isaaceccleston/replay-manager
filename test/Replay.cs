public class Replay(){
    public string header_size; 
    public string header_crc;
    public string major_version;
    public string minor_version;
    public string net_version;
    public string game_type;
    public Properties properties;
    public string content_size;
    public string content_crc;
    public NetworkFrames network_frames;
    public string[] levels;
    public Keyframe[] keyframes;
    public Debug[] debug_info;
    public TickMark[] tick_marks;
    public string[] packages;
    public string[] objects;
    public string[] names;
    public ClassIndex[] class_indices;

    public List<string> GetPlayerNames(){
        List<string> players = new List<string>();
        foreach(PlayerStat stat in properties.PlayerStats){
            players.Add(stat.Name);
        }
        return players;
    }

    public List<Actor> GetAllActors(){
        List<Actor> actors = new List<Actor>();
        foreach(Frame frame in network_frames.Frames){
            foreach(Actor actor in frame.GetAllActorsInFrame()){
                if(!actors.Contains(actor)){
                    actors.Add(actor);
                }
            }
        }
        return actors;
    }

    public List<int> GetObjectsOfActor(int actorID){
        List<int> objects = new List<int>();
        foreach(Frame frame in network_frames.Frames){
            foreach(Actor actor in frame.GetAllActorsInFrame()){
                if(actor.actor_id != actorID){
                    break;
                }
                if(objects.Contains(actor.object_id)){
                    break;
                }
                objects.Add(actor.object_id);
            }
        }
        return objects;
    }
}