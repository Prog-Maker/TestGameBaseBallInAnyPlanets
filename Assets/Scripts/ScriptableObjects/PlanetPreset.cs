using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Planet PreSet", menuName = "Plane Presets/New Planet Preset")]
public class PlanetPreset : ScriptableObject
{
    public string PlanetName;
    
    public Vector2 Gravity;

    public Color PlanetBackGroundColor;
}
