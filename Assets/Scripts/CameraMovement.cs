using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target; 
    public Transform target2; 
    public Transform target3;  
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }else if(transform.position != target2.position)
        {
            Vector3 targetPosition2 = new Vector3(target2.position.x, target2.position.y, transform.position.z);

            targetPosition2.x = Mathf.Clamp(targetPosition2.x, minPosition.x, maxPosition.x);
            targetPosition2.y = Mathf.Clamp(targetPosition2.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, targetPosition2, smoothing);
        }else if(transform.position != target3.position)
        {
            Vector3 targetPosition3 = new Vector3(target3.position.x, target3.position.y, transform.position.z);

            targetPosition3.x = Mathf.Clamp(targetPosition3.x, minPosition.x, maxPosition.x);
            targetPosition3.y = Mathf.Clamp(targetPosition3.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, targetPosition3, smoothing);
        }
    }
}
