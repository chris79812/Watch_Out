
using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;
using System.Collections;
public class CloudGeneratorScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] clouds;

    [SerializeField]
    float spawnInterval;

    [SerializeField]
    GameObject endPoint;

    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
        PreWarm();
        Invoke("AttemptSpawn", spawnInterval);
    }

    // cloud values like size and speed and where it spawns
    void SpawnCloud(Vector3 startPos)
    {
        int randomIndex = UnityEngine.Random.Range(0, 4);
        GameObject cloud = Instantiate(clouds[randomIndex]);

        float startPosZ = UnityEngine.Random.Range(startPos.y - 20f, startPos.y + 10f);
        float startPosX = UnityEngine.Random.Range(startPos.y - 2f, startPos.y + 1f);
        float startY = UnityEngine.Random.Range(startPos.y - 20f, startPos.y + 40f);
        cloud.transform.position = new Vector3(startPosX, startY, startPosZ); ;
        

        float scale = UnityEngine.Random.Range(8.8f, 7.2f);
        cloud.transform.localScale = new Vector3(scale, scale, scale);

        float speed = UnityEngine.Random.Range(2.5f, 3.5f);
        cloud.GetComponent<CloudScript>().StartFloating(speed, endPoint.transform.position.x);



    }

    void AttemptSpawn()
    {
        //checks some things
        SpawnCloud(startPos);

        Invoke("AttemptSpawn", spawnInterval);
    }

    void PreWarm()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPos = startPos + Vector3.left * (i * 2);
            SpawnCloud(spawnPos);
        }
    }

}



