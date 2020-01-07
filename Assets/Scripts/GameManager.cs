using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private Dictionary<GameEventType, Action> ActionsDict = new Dictionary<GameEventType, Action>();

    private void Awake()
    {
        // Проверяем экземпляр объекта
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance == this)
        {
            Destroy(gameObject);
        }

        // Даем понять движку, что его не нужно уничтожать
        DontDestroyOnLoad(gameObject);
        
        RegisterAllTypeEvents();
    }

    private void RegisterAllTypeEvents()
    {
        foreach (var item in Enum.GetValues(typeof(GameEventType)))
        {
            RegisterAction(null, (GameEventType)item);
        }
    }


    public void RegisterAction(Action action, GameEventType gameEventTypeAction)
    {
        if (!ActionsDict.ContainsKey(gameEventTypeAction))
        {
            ActionsDict.Add(gameEventTypeAction, action);
        }
    }

    public void InvokeAction(GameEventType gameEventTypeAction)
    {
        if (ActionsDict.ContainsKey(gameEventTypeAction))
        {
            ActionsDict[gameEventTypeAction]?.Invoke();
        }
    }

    public void AddListerner(Action action, GameEventType gameEventTypeAction)
    {
        if (ActionsDict.ContainsKey(gameEventTypeAction))
        {
            ActionsDict[gameEventTypeAction] += action;
        }
    }

}

public enum GameEventType
{
    GameStart, OnHit, OpenMainMenu, CloseMainMenu
}
