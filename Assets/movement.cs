using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
 
        
    }
public float speed = 100.0f;
 public float turnSpeed = 60.0f;
    // Update is called once per frame
    void Update()
    {
      Transform t = gameObject.transform;
       float throttle = Input.GetAxis("Vertical");
    float steering = Input.GetAxis("Horizontal");
     float move = throttle*speed*Time.deltaTime;
        float turn = steering*turnSpeed*Time.deltaTime;

    
    t.Translate(0.0f,0.0f,move);
       t.Rotate(0.0f,turn,0.0f);
    }
}
