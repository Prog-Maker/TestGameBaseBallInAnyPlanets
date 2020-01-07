using UnityEngine;
using UnityEngine.UI;

public class SetTextForButton : MonoBehaviour
{
    [SerializeField]
    private Text textField;

    public void SetText(string text)
    {
        if(textField) textField.text = text;
    }
}
