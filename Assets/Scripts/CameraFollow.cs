using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 offSet = new Vector3(0, 5, -10);


    private void Start()
    {
        transform.position = player.position + offSet;
    }

    private void LateUpdate()
    {
        Vector3 DesiredPosition = player.position + offSet;
        DesiredPosition.x = 0;
        transform.position = Vector3.Lerp(transform.position, DesiredPosition, Time.deltaTime);
    }
}

