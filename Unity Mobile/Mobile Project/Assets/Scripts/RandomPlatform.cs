using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlatform : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefab4;
    int WhatToSPawn;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        WhatToSPawn = Random.Range(1, 5);
        switch (WhatToSPawn)
        {
            case 1:
                Instantiate(prefab1, transform.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(prefab2, transform.position, Quaternion.identity);
                break;
            case 3:
                Instantiate(prefab3, transform.position, Quaternion.identity);
                break;
            case 4:
                Instantiate(prefab4, transform.position, Quaternion.identity);
                break;
        }
    }
}
