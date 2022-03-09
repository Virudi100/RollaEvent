using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private GameObject wall;


    private void Start()
    {
        wall.SetActive(false);
    }

    private void OnEnable()
    {
        Trigger.triggerPlayer += SpawnWall;
    }

    private void OnDisable()
    {
        Trigger.triggerPlayer -= SpawnWall;
    }

    void SpawnWall()
    {
        wall.SetActive(true);
        Destroy(gameObject);
    }
}
