using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject Logo;
    public GameObject playButton;
    public GameObject optionButton;
    public GameObject exitButton;
    public GameObject Logo2;
    public int OptionSwitch = 1;

    public void OptionButton()
    {
        if (OptionSwitch == 1)
        {
            OptionSwitch = 0;
            Logo.SetActive(false);
            playButton.SetActive(false);
            optionButton.SetActive(false);
            exitButton.SetActive(false);
            Logo2.SetActive(true);

        }
        else if (OptionSwitch == 0)
        {
            OptionSwitch = 1;
            Logo.SetActive(true);
            playButton.SetActive(true);
            optionButton.SetActive(true);
            exitButton.SetActive(true);
            Logo2.SetActive(false);

        }

    }
}
