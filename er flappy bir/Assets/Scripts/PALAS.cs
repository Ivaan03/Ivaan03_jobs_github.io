using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PALAS : MonoBehaviour
{
    public Transform T_;

    public Transform TT_;

    public float tiltAngle;

    public float kk;

    public HingeJoint hinge;

    public float spring;

    public float damper;

    public float tP;
   
        // Start is called before the first frame update
    void Start()
    {
            HingeJoint hinge = GetComponent<HingeJoint>();

           

            kk = 100000.0f;

            spring = 10000.0f;

            damper = 0;

            tP = 70.0f;

            JointSpring hingeSpring = hinge.spring;

            hinge.spring = hingeSpring;

            hinge.useSpring = true;
    }

        // Update is called once per frame
    void Update()
    {
         if (T_)
         {

            if (Input.GetKeyDown(KeyCode.A))
            {
                JointSpring hingeSpring = hinge.spring;

                hingeSpring.spring = spring;

                hingeSpring.damper = damper;

                hingeSpring.targetPosition = tP;

                hinge.spring = hingeSpring;

            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                JointSpring hingeSpring = hinge.spring;

                hingeSpring.targetPosition = 0;

                hinge.spring = hingeSpring;
            }                                     
           
         }
        if (TT_)
        {

            if (Input.GetKeyDown(KeyCode.D))
            {
                JointSpring hingeSpring = hinge.spring;

                hingeSpring.spring = spring;

                hingeSpring.damper = damper;

                hingeSpring.targetPosition = tP;

                hinge.spring = hingeSpring;

            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                JointSpring hingeSpring = hinge.spring;

                hingeSpring.targetPosition = 0;

                hinge.spring = hingeSpring;
            }

        }

    }
}
