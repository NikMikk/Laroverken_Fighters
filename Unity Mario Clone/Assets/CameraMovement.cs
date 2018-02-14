using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(target.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * moveSpeed);
    }
}
