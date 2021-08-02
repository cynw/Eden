using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target;
    public float smoothing;
    public Vector3 maxPosition;
    public Vector3 minPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }



    void LateUpdate()
    {
        if (transform.position  != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x, transform.position.y, target.position.z);
            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.z = Mathf.Clamp(targetPosition.z, minPosition.z, maxPosition.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}
