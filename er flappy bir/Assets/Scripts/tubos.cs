using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubos : MonoBehaviour
{
    public Transform Paco_Sanz;

    public float Altura;


   


    //public float Ramon = 0.0002f;

    // Start is called before the first frame update
    void Start()
    {


      


    }
    
    private void OnCollisionEnter(Collision collision)
    {

        Paco_Sanz.Translate(-6.0f,0.0f,0.0f);
        Debug.Log("Me muevo");
       



    }



        // Update is called once per frame
    void Update()
    {
        if (Paco_Sanz)
        {
            Paco_Sanz.Translate(0.015f, 0.0f, 0.0f);

            if (Paco_Sanz.position.x > 26.0f)
            {
                Altura = Random.Range(15f, 19f);

                Paco_Sanz.position = new Vector3(-71.0f, Altura, 0.0f);

            }
            
        }
               
    }


}
