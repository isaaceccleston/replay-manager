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