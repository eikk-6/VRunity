using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caaaaaaaandle : MonoBehaviour
{

    Rigidbody rigidbody;
    private bool isfire = false;

    public GameObject onflame;
    private GameObject desflame;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rigidbody.velocity.magnitude > 1)
        {
            off();
        }
    }
    private void off()
    {
        isfire = false;
        
    }
}
