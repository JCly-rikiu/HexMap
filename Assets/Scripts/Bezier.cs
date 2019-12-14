using UnityEngine;

public static class Bezier
{
    public static Vector3 GetPoint(Vector3 a, Vector3 b, Vector3 c, float t)
    {
        float r = 1f - t;
        return r * r * a + 2f * r * t * b + t * t * c;
    }
}
