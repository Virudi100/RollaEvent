using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Material))]
public class Player : MonoBehaviour
{
    private float speed = 500f;

    private void OnEnable()
    {
        InputManager.right += MoveRight;
        InputManager.Up += MoveUp;
        Trigger.triggerPlayer += ChangeColor;
    }

    private void OnDisable()
    {
        InputManager.right -= MoveRight;
        InputManager.Up -= MoveUp;
        Trigger.triggerPlayer -= ChangeColor;
    }

    void MoveRight(float value)
    {
        print("MoveRight");
        gameObject.GetComponent<Rigidbody>().AddForce(value * speed * Time.deltaTime,0 , 0);
    }

    void MoveUp(float value)
    {
        print("MoveUp");
        gameObject.GetComponent<Rigidbody>().AddForce(0, 0, value * speed * Time.deltaTime);
    }

    void ChangeColor()
    {
        gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV(0, 1, 0, 1, 0, 1);
    }
}
