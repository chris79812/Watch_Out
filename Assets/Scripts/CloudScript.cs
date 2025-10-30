using UnityEngine;

public class CloudScript : MonoBehaviour
{
    //variables
    private float Speed;
    private float EndPosX;



    public void StartFloating(float speed, float endPosX)
    {
        Speed = speed;
        EndPosX = endPosX;

    }


    // moves the clouds left and destroys them
    void Update()
    {
        transform.Translate(Vector3.left * (Time.deltaTime));

        if (transform.position.x > EndPosX)
        {
            Destroy(gameObject);
        }



    }
}
