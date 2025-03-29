public class String3(){
    public string x{get;set;}
    public string y{get;set;}
    public string z{get;set;}

    public override string ToString()
    {
        return $"x:{x}, y:{y}, z:{z}";
    }
}