using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTransform;
    Vector3 Offset;

    // Start is called before the first frame update
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransform.position;
    }

    // UI나 camera는 late update에서 이루어진다.
    // update에서 연산을 다 한 후에 이루어 지기 때문에
    void LateUpdate()
    {
        transform.position = playerTransform.position + Offset;
    }
}
