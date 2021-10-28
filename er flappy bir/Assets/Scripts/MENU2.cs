using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
public class MENU2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        


    }

    public void FlappyFroggy()
    {

        SceneManager.LoadScene("rana");

    }
    public void PainBall()
    {

        SceneManager.LoadScene("Painball");

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
