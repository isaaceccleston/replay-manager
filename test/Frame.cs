using System.Diagnostics;

public class Frame(){
    public float time;
    public float delta;
    public Actor[] new_actors;
    public int[] deleted_actors;
    public Actor[] updated_actors;

    public Actor[] GetAllActorsInFrame(){
        Actor[] allActors = new Actor[new_actors.Length + updated_actors.Length];
        for (int i = 0; i < new_actors.Count(); i++)
        {
            allActors[i] = new_actors[i];
        }
        for (int i = 0; i < updated_actors.Count(); i++){
            allActors[new_actors.Count() + i] = updated_actors[i];
        }
        return allActors;
    }

}