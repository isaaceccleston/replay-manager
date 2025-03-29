public class Replay(){
    public string header_size {get; set;}
    public string header_crc {get; set;} 
    public string major_version {get; set;}
    public string minor_version {get; set;}
    public string net_version {get; set;}
    public string game_type {get; set;}
    public Properties properties {get; set;}
    public string content_size {get; set;}
    public string content_crc {get; set;}
    public NetworkFrames network_frames {get; set;}
    public string[] levels{get;set;}
    public Keyframe[] keyframes{get;set;}
    public Debug[] debug_info{get;set;}
    public TickMark[] tick_marks{get;set;}
    public string[] packages{get;set;}
    public string[] objects{get;set;}
    public string[] names{get;set;}
    public ClassIndex[] class_indices{get;set;}
}