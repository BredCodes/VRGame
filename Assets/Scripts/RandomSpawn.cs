using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public List <GameObject> spawnList = new List <GameObject>();
    public List <GameObject> animalList = new List <GameObject>();
    float posX;
    float posY;
    float posZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i< spawnList.Count; i++)
        {
            posX = spawnList[Random.Range(0, spawnList.Count)].transform.position.x;
            Instantiate(animalList[Random.Range(0, animalList.Count)], new Vector3(posX, posY, posZ), Quaternion.identity);
        }
    }
}
