using UnityEngine;
using UnityEngine.UI;

public class CounterHits : MonoBehaviour
{
    [SerializeField]
    private Text textField;

    public int Counter { get; private set; }

    private void Start()
    {
        GameManager.Instance.AddListerner(MoveCounter, GameEventType.OnHit);
    }

    public void MoveCounter()
    {
        textField.text = (++Counter).ToString();
    }
}
