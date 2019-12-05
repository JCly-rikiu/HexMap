using UnityEngine;

public struct HexHash
{
    public float a, b, c;

    public static HexHash Create()
    {
        HexHash hash;
        hash.a = Random.value * 0.999f;
        hash.b = Random.value * 0.999f;
        hash.c = Random.value * 0.999f;
        return hash;
    }
}
