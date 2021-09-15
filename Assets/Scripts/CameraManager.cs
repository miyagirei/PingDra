using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject targetPlayer = default;
    Vector3 pos = default;
    void Start()
    {
        pos = Camera.main.gameObject.transform.position;
    }

    
    void Update()
    {
        Vector3 cameraPos = targetPlayer.transform.position;

        if(targetPlayer.transform.position.x < 0)
        {
            cameraPos.x = 0;
        }

        cameraPos.y = pos.y;
        cameraPos.z = pos.z;

        Camera.main.gameObject.transform.position = cameraPos;
    }
}
