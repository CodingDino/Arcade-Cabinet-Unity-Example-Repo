using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class InputDiagnostic : MonoBehaviour
{

    public Text keyPressed = null;

    public Text player1Hor = null;
    public Text player1Vert = null;

    public float buttonClearTime = 1.0f;

    private float lastButtonTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Joystick names:");
        string[] names = Input.GetJoystickNames();
        foreach ( var name in names)
        {
            Debug.Log(name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        string keysPressed = "";
        foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(kcode))
                keysPressed += kcode.ToString() + "\n";
                // Debug.Log("KeyCode down: " + kcode);
        }
        if (keysPressed != "" || Time.time >= lastButtonTime+buttonClearTime)
        {
            keyPressed.text = keysPressed;
            lastButtonTime = Time.time;
        }

        float xPlayer1 = Input.GetAxis("Horizontal-Player1");
        player1Hor.text = xPlayer1.ToString();
        //Debug.Log("Player 1 - X Axis - " + xPlayer1);

        float yPlayer1 = Input.GetAxis("Vertical-Player1");
        player1Vert.text = yPlayer1.ToString();
        //Debug.Log("Player 1 - Y Axis - " + yPlayer1);
    }
}
