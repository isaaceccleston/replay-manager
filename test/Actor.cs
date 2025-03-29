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