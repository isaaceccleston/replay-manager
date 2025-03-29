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