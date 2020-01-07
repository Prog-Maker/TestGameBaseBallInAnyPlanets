using System;
using UnityEngine;

public class MenuButton : MonoBehaviour, IButton
{
    //Action action;

    //private void Start()
    //{
    //    GameManager.Instance.RegisterAction(action, GameEventType.CloseMainMenu);
    //}

    public void Execute()
    {
        GameManager.Instance.InvokeAction(GameEventType.CloseMainMenu);
    }
}
