using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class main_menu : MonoBehaviour
{

    public GameObject G_;

    public GameObject O_;

    // Start is called before the first frame update
    void Start()
    {

        O_ = GameObject.Find("Opsiones");
        O_.SetActive(false);
    }
    public void Play()
    {

        SceneManager.LoadScene("menu2");

    }

    public void Options()
    {     

        G_ = GameObject.Find("Menu");

        G_.SetActive(false);

        O_.SetActive(true);
    }
    public void Back()
    {       
        G_.SetActive(true);

        O_.SetActive(false);
    }
    public void Exit()
    {

        EditorApplication.Exit(0);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
