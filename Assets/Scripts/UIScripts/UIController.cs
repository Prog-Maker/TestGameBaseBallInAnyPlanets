using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject MainMenuPanel;

    private bool mainMenuIsOpen = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainMenuIsOpen = MainMenuPanel.activeSelf;
            if (!mainMenuIsOpen)
            {
                MainMenuPanel?.SetActive(!mainMenuIsOpen);
            }
            else
            {
                MainMenuPanel?.SetActive(!mainMenuIsOpen);
            }
        }
    }
}
