﻿using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public void ButtomClicked(string ButtomName)
    {
        if (ButtomName == "Play")
        {
            Application.LoadLevel("Game");
        }
        if (ButtomName == "Menu")
        {
            Application.LoadLevel("Menu");
        }
    }
}