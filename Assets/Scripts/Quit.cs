using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Quits the player when the user hits escape

public class Quit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
