using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
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

        Invoke("AttemptSpawn", spawnInterval);
    }


    

    // spawns clouds 
    void SpawnCloud()
    {
        int randomIndex = UnityEngine.Random.Range(0, 4);
        GameObject cloud = Instantiate(clouds[randomIndex]);

        startPos.y = UnityEngine.Random.Range(startPos.y - 1f, startPos.y + 1f);
        cloud.transform.position = startPos;

        float scale = UnityEngine.Random.Range(1.2f, 6.3f);
        cloud.transform.localScale = new Vector2(scale, scale);

        float speed = UnityEngine.Random.Range(0.5f, 1.5f);
        cloud.GetComponent<CloudScript>().StartFloating(speed, endPoint.transform.position.x);



    }

    void AttemptSpawn()
    {
        //checks some things
        SpawnCloud();

    }


   
}
