using System;
using UnityEngine;

public class HitRegister : MonoBehaviour
{
    //private Action onHit;

    //private void Start()
    //{
    //    GameManager.Instance.RegisterAction(onHit, GameEventType.OnHit);
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.InvokeAction(GameEventType.OnHit);
        //onHit?.Invoke();
    }
}
