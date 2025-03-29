public class RigidBody(){
    public bool sleeping;
    public String3 location;
    public String4 rotation;
    public String3 linear_velocity;
    public String3 angular_velocity;

    public override string ToString()
    {
        return $"Rigidbody:\n\t\t[s:{sleeping},\n\t\tl:{location},\n\t\tr:{rotation},\n\t\tlv:{linear_velocity},\n\t\tav:{angular_velocity}]";
    }
}