using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public delegate void PlayerEnterTrigger();
    public static event PlayerEnterTrigger triggerPlayer;

    private void OnTriggerEnter(Collider other)
    {
        triggerPlayer.Invoke();
    }
}
