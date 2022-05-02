
using UnityEngine;

public class RotatingCamera : MonoBehaviour
{
    //Assign a target GameObject in the Inspector to rotate around
    public GameObject target;
    
    //Assign a number in the Inspector for the amount of degrees
    public float degree;
    
    void Update()
    {
        // Spin the camera around the target at defined in the Inspector degrees/second.
        transform.RotateAround(target.transform.position, Vector3.up, degree * Time.deltaTime);
    }
}
