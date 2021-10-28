using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Lanita : MonoBehaviour
{
    public float Conchita = 7.0f;

    public Rigidbody Mamen;  

    public Transform Raiola;

    public float glavelal = -1.0f;

    public Text m_MyText;

    public Text m_;

    public int tupapa = 0;

    public int vidas;

    [Header("Knockback")]
    public float knockback_value_ = 1.0f;
    public Transform Señor;

    // Start is called before the first frame update
    void Start()
    {
        Señor = GameObject.Find("TITOSORIA").GetComponent<Transform>();

        vidas = 5;

        Mamen = GetComponent<Rigidbody>();

       
            m_MyText = GameObject.Find("Text").GetComponent<Text>();           

            m_MyText.text = "" + tupapa;   
                
            m_ = GameObject.Find("Texto_Paco").GetComponent<Text>();

            m_.text = "TE QUEDAN: " + vidas + " VIDAS";
       
        


    }



    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Eres mas malo que paco sanz estafando y que peru en los mundiales");

        Señor.Translate(-transform.right * knockback_value_);

        //GetComponent<Lanita>().enabled = false;
       

        if (vidas <= 0)
        {

            SceneManager.LoadScene("Menu");

        }
        vidas--;


    }
    private void OnTriggerExit(Collider other)
    {

        GameManager.Instance.R_ = tupapa;

        tupapa++;

        Debug.Log("tupapa: " + tupapa);

        Debug.Log("vidas: " + vidas);

        
    }
    // Update is called once per frame
    void Update()
    {

        GameManager.Instance.Pa_ = glavelal;

        Debug.Log(glavelal);

        Mamen.AddForce(0.0f, glavelal, 0.0f, ForceMode.Impulse);
        if (Mamen)
        {

            

            if (Input.GetKey("space"))
            {
                
                 
                Mamen.AddForce(Vector3.up * Conchita);

               
            }
            if (Input.GetKey("up"))
            {

                Time.timeScale = 0f;



            }
           
        }

        m_MyText.text = ""+ tupapa;

        m_.text = "TE QUEDAN: " + vidas + " VIDAS";
    }

}
