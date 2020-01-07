using UnityEngine;


public class ColorSwitcher : MonoBehaviour
{
    [SerializeField]
    private Color[] colors;

    private SpriteRenderer sRenderer;

    private void Awake()
    {
        sRenderer = GetComponent<SpriteRenderer>();
    }

    private int RandomColor => Random.Range(0, colors.Length);

    private void SwitchColor()
    {
        sRenderer.color = colors[RandomColor];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SwitchColor();
    }
}
