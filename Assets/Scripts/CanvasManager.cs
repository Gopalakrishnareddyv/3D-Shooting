using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject main;
    public GameObject help;
    public GameObject options;
    public void MainPanel()
    {
        main.SetActive(true);
        help.SetActive(false);
        options.SetActive(false);
    }
    public void HelpPanel()
    {
        main.SetActive(false);
        help.SetActive(true);
        options.SetActive(false);
    }
    public void OptionsPanel()
    {
        main.SetActive(false);
        help.SetActive(false);
        options.SetActive(true);
    }
}
