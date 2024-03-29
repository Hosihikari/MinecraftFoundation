using Hosihikari.NativeInterop.Generation;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft.Mce;

[StructLayout(LayoutKind.Sequential)]
[PredefinedType(NativeTypeName = "Color", NativeTypeNamespace = "mce")]
public struct Color(float r, float g, float b, float a)
{
    public float R = r;
    public float G = g;
    public float B = b;
    public float A = a;
}