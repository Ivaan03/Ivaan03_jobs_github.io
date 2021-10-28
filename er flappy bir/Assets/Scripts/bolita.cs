using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolita : MonoBehaviour
{
    public Rigidbody LaKarmeleLoko;



    // Start is called before the first frame update
    void Start()
    {

        LaKarmeleLoko = GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {
        LaKarmeleLoko.AddForce(0.0f, -0.075f, 0.0f, ForceMode.Impulse);


    }


}
