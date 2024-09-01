using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMoveScript : MonoBehaviour
{
    public float cloudMoveSpeed;
    public float cloudDeadZone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * cloudMoveSpeed) * Time.deltaTime;
        if (transform.position.x < cloudDeadZone)
        {
            Debug.Log("Cloud Deleted");
            Destroy(gameObject);
        }
    }
}
