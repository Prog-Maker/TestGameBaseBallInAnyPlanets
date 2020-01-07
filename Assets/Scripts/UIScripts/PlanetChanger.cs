using System;
using UnityEngine;

public class PlanetChanger : MonoBehaviour
{
    private Action<int> changePlanetAction;

    private int index;

    private void ChangePlanet(int index)
    {
        changePlanetAction.Invoke(index);
    }

    public void SetIndexAndAction(int index, Action<int> action)
    {
        this.index = index;
        changePlanetAction = action;
    }

    public void OnClck()
    {
        ChangePlanet(index);
    }
}
