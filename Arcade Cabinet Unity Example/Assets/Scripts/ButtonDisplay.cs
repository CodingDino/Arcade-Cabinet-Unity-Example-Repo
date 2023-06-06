using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDisplay : MonoBehaviour
{
    Toggle buttonDisplay;

    [SerializeField]
    KeyCode keyCode;

    private void Start()
    {
        buttonDisplay = GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        buttonDisplay.isOn = Input.GetKey(keyCode);
    }
}
