using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretrotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float turnSpeed = 80.0f;
    // Update is called once per frame
    void Update()
    {
        float rotate = 0.0f;
        if(Input.GetKey(KeyCode.Q)){
            rotate = -turnSpeed * Time.deltaTime;
        }else if(Input.GetKey(KeyCode.E)){
            rotate = turnSpeed * Time.deltaTime;
        }
        Transform t = gameObject.transform;
        t.Rotate (0.0f,rotate,0.0f);
    }
}
