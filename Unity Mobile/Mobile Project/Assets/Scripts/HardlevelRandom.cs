using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardlevelRandom : MonoBehaviour
{
    public GameObject Spawner;
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6, prefab7, prefab8;
    int WhatToSPawn;
    private void OnTriggerEnter2D(Collider2D collision)



    {
        WhatToSPawn = Random.Range(1, 5);
        switch (WhatToSPawn)
        {
            case 1:
                Instantiate(prefab1, Spawner.transform.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(prefab2, Spawner.transform.position, Quaternion.identity);
                break;
            case 3:
                Instantiate(prefab3, Spawner.transform.position, Quaternion.identity);
                break;
            case 4:
                Instantiate(prefab4, Spawner.transform.position, Quaternion.identity);
                break;
            case 5:
                Instantiate(prefab4, Spawner.transform.position, Quaternion.identity);
                break;
            case 6:
                Instantiate(prefab4, Spawner.transform.position, Quaternion.identity);
                break;
            case 7:
                Instantiate(prefab4, Spawner.transform.position, Quaternion.identity);
                break;
            case 8:
                Instantiate(prefab4, Spawner.transform.position, Quaternion.identity);
                break;
        }
        Destroy(gameObject);
    }
}
