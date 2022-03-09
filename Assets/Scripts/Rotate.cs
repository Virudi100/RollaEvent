using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Vector3 rotation;

    // Update is called once per frame
    void Update()
    {
        //fais tourner le cube en continue
        rotation.y = 50f * Time.deltaTime;
        this.gameObject.transform.Rotate(rotation);
    }
}
