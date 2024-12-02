using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Move_Script : MonoBehaviour
{
    public float moveSpeed = 2;
    public float deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed)* Time.deltaTime * 2;
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);

        }
    }
}
