using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseOpenListerner : MonoBehaviour
{
    
    void Start()
    {
        GameManager.Instance.AddListerner(Open, GameEventType.OpenMainMenu);
        GameManager.Instance.AddListerner(Close, GameEventType.CloseMainMenu);
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
