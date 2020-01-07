using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(GravityControl))]
[RequireComponent(typeof(ColorSceneControl))]
public class PlanetController : MonoBehaviour
{
    [SerializeField]
    private GravityControl gravityControl;

    [SerializeField]
    private ColorSceneControl colorSceneControl;

    [SerializeField]
    private SpriteRenderer bgRenderer;

    [SerializeField]
    private PlanetPreset[] presets;

    private Action<int> action;

    private void Awake()
    {
        gravityControl = GetComponent<GravityControl>();
        colorSceneControl = GetComponent<ColorSceneControl>();
        colorSceneControl.Add(bgRenderer);
        action += SetPreset;
        SetPreset(0);
    }

    public void SetPreset(int index)
    {
        gravityControl.SetGravitySettings(presets[index].Gravity);
        colorSceneControl.SetColor(presets[index].PlanetBackGroundColor);
    }

    public int PlanetCount => presets.Length;

    public Action<int> GetAction(int i) => action;

    public string PlanetName(int index)
    {
        if (index < presets.Length)
        {
            return presets[index].PlanetName;
        }
        return "";
    }

}
