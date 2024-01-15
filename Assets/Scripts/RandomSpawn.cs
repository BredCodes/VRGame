using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public List <GameObject> spawnList = new List <GameObject>();
    public List <GameObject> animalList = new List <GameObject>();
        Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < animalList.Count; i++)
        {
            pos = spawnList[Random.Range(0, spawnList.Count)].transform.position;
            Instantiate(animalList[Random.Range(0, animalList.Count)], pos, Quaternion.identity);

        }
    }
}
