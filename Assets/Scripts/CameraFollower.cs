using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField]
    Transform followTarget;
    [SerializeField]
    Vector3 offset;

    void Start()
    {
        if (offset == Vector3.zero)
        {
            offset = transform.position - followTarget.position;
        }
        /* Esconder el cursor del Mouse */
        Cursor.visible = false;
    }
    void LateUpdate()
    {
        Vector3 targetPosition = followTarget.position + offset;
        transform.position = targetPosition;
        transform.LookAt(followTarget);
    }
}
