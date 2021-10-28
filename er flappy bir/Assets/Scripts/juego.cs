using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.Audio;

public class juego : MonoBehaviour
{
   
    public AudioMixer masterMixer;

    // Start is called before the first frame update
    void Start()
    {
      
        if (masterMixer)

            masterMixer.SetFloat("musicVol", GameManager.Instance.lana);

            
   
    }


    public void Menu()
    {

        SceneManager.LoadScene("Menu");

    }


    // Update is called once per frame
    void Update()
    {

       
       
    }
}
