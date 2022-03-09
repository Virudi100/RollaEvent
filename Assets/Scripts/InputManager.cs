using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputManager : MonoBehaviour
{
    public delegate void InputsAxis(float value);
    public static event InputsAxis right;
    public static event InputsAxis Up;

    

    // Update is called once per frame
    void Update()
    {
        IsInput();
    }

    void IsInput()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            right?.Invoke(Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            Up?.Invoke(Input.GetAxis("Vertical"));
        }
    }
}
