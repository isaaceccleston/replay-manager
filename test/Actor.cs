public class Actor(){
    public int actor_id;
    public int name_id;
    public int object_id;
    public Trajectory initial_trajectory;
    public Attribute attribute;

    public override string ToString()
    {
        return $"ActorId: {actor_id}, NameId: {name_id}, ObjectId: {object_id}";
    }
}