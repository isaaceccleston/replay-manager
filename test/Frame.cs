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