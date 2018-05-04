using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class Vector2Extensions
{
    public static Vector2 Sum(this IEnumerable<Vector2> source)
    {
        return source.Aggregate(Vector2.zero, (current, next) => current + next);
    }

    public static Vector3 X0Y(this Vector2 vector2)
    {
        return new Vector3(vector2.x, 0, vector2.y);
    }
}
