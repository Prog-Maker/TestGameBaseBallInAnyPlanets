using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(VerticalLayoutGroup))]
public class ButtonsMenuCreator : MonoBehaviour
{
    [SerializeField]
    private PlanetChanger buttonChangerBrefab;

    [SerializeField]
    private PlanetController planetController;


    private void Awake()
    {
        planetController = FindObjectOfType<PlanetController>();
    }
    private void Start()
    {
        if (planetController)
        {
            for (int i = 0; i < planetController.PlanetCount; i++)
            {
                var button = Instantiate(buttonChangerBrefab);
                button.transform.SetParent(transform);
                button.SetIndexAndAction(i, planetController.GetAction(i));
                var settxt = button.GetComponent<SetTextForButton>();
                if (settxt) settxt.SetText(planetController.PlanetName(i));
            }
        }
    }
}
