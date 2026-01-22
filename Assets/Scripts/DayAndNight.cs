using UnityEngine;

public class DayAndNight : MonoBehaviour
{

    Vector3 rot = Vector4.zero;
    double degepersec = -0.05;

    void Update()
    {


        rot.x = (float)(degepersec * Time.deltaTime);
        transform.Rotate(rot, Space.World);


    }
}
