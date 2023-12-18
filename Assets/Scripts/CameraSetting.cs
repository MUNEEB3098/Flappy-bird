using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetting : MonoBehaviour
{
    GameObject obj;
    
    // Start is called before the first frame update
    private void Awake()
    {
        obj = GameObject.FindWithTag("Player");
        
    }
    

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos= obj.transform.position;
        pos.y = -0.05f;
        pos.z = -10;
        transform.position = pos;
    }
}
