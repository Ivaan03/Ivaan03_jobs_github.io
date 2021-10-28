using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titosoria : MonoBehaviour
{
    private tubos[] scriptsA;
    
    public Transform l;

    // Start is called before the first frame update
    void Start()
    {

        scriptsA = FindObjectsOfType<tubos>();

       

    }
    private void OnCollisionEnter(Collision collision)
    {


        l.Translate(-6.0f, 0.0f, 0.0f);




    }
    // Update is called once per frame
    void Update()
    {
        if (l)
        {


            l.Translate(0.015f, 0.0f, 0.0f);

        

        }



    }
}
