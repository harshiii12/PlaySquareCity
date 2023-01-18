using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] WheelCollider fro;
    [SerializeField] WheelCollider br;
    [SerializeField] WheelCollider bl;

    public float acc = 500f;
    public float bre = 300f;
    public float mta = 15f;

    private float ca = 0f;
    private float cb = 0f;
    private float cta = 0f;

    private void FixedUpdate()
    {
        ca = acc * Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
            cb = bre;
        else
            cb = 0f;


        fro.motorTorque = ca;

        fro.brakeTorque = cb;
        br.brakeTorque = cb;
        bl.brakeTorque = cb;

        


        cta = mta * Input.GetAxis("Horizontal");
        fro.steerAngle = cta;
    }

} 
