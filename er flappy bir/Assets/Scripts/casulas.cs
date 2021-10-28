using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class casulas : MonoBehaviour
{
    public Rigidbody Paco;

    public Collider coll;

    private void OnCollisionEnter(Collision collision)
    {


            

            PhysicMaterial material = new PhysicMaterial();

            material.dynamicFriction = 0.3f;

            material.bounciness = 1;

            coll.material = material;

            coll.attachedRigidbody.useGravity = true;
    }
    // Start is called before the first frame update
    void Start()
    {

        coll = GetComponent<Collider>();

        Paco = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        



    }
}
