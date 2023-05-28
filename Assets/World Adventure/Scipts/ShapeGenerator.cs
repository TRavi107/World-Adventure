using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGenerator : MonoBehaviour
{
    public float radius=10;

    public Vector3 CalculatePointOnPlanet(Vector3 pointOnSphere)
    {
        return pointOnSphere * radius;
    }
}
