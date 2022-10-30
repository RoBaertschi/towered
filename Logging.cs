using Godot;

public static class Logging
{
    public static void warn(string text, string name) {
        GD.Print("[WARNING] [", name,"]: ",text);
    }
    public static void warn(string text) {
        warn(text, "MyMonoProject");
    }

    public static void info(string text, string name) {
        GD.Print("[INFO] [", name,"]: ",text);
    }
    public static void info(string text) {
        info(text, "MyMonoProject");
    }

    public static void error(string text, string name) {
        GD.PrintErr("[ERROR] [", name,"]: ",text);
    }
    public static void error(string text) {
        error(text, "MyMonoProject");
    }
}
    
