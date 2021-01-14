
using UnityEngine;

public static class HexMetrics
{
    public const float outerRadius = 10f;
    public static float innerRadius = outerRadius * 0.866025404f;

    public readonly static Vector3[] corners = new Vector3[]
    {
        new Vector3(0f, 0f, outerRadius),
        new Vector3(innerRadius, 0f, 0.5f * outerRadius),
        new Vector3(innerRadius, 0f, -0.5f * outerRadius),
        new Vector3(0f, 0f, -outerRadius),
        new Vector3(-innerRadius, 0f, -0.5f * outerRadius),
        new Vector3(-innerRadius, 0f, 0.5f * outerRadius),
        new Vector3(0,0,outerRadius),
    };

}