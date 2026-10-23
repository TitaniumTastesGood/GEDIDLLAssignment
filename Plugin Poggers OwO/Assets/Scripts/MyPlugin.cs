using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public struct Vector2D
{
    public float x;
    public float y;
}
public static class MyPlugin
{
    [DllImport("Dll_Test_Wow")]
    private static extern int GetID();
    [DllImport("Dll_Test_Wow")]
    private static extern int SetID(int id);
    [DllImport("Dll_Test_Wow")]
    private static extern Vector2D GetPosition();
    [DllImport("Dll_Test_Wow")]
    private static extern Vector2D GetPosition(float x, float y);
    public static int ID
    {
        get { return GetID(); }
        set { SetID(value); }
    }
    public static Vector2D Position
    {
        get { return GetPosition(); }
    }
}
