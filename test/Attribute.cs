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