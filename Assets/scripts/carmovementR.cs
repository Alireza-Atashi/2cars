using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class car : MonoBehaviour
{
    public float lane1Z = 6/5f;     
    public float lane2Z = 3/5f;         
    public float zMoveSpeed = 10f;       

    private float targetZ;               

    void Start()
    {
        targetZ = lane1Z;
        SetZPositionImmediately(targetZ);
    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKeyDown(KeyCode.G))
        {
            targetZ = Mathf.Approximately(targetZ, lane1Z) ? lane2Z : lane1Z;
        }

        Vector3 currentPosition = transform.position;
        float newZ = Mathf.MoveTowards(currentPosition.z, targetZ, zMoveSpeed * Time.deltaTime);
        transform.position = new Vector3(currentPosition.x, currentPosition.y, newZ);
    }
    void SetZPositionImmediately(float z)
    {
        Vector3 pos = transform.position;
        pos.z = z;
        transform.position = pos;
    }
}
