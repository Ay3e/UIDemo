using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button playButton;

    void Start()
    {
        //Select the PLAY button so it is ready to be pressed!
        playButton.Select();
        //Hide the mouse cursor
        Cursor.visible = false;
        //Prevent the cursor from existing out game window
        Cursor.lockState = CursorLockMode.Confined;
    }
}
