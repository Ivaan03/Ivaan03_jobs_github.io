using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Music : MonoBehaviour
{

    public AudioMixer masterMixer;

    public void SetSound(float soundLevel)
    {

        masterMixer.SetFloat("musicVol", soundLevel);
        GameManager.Instance.lana = soundLevel;     
    }

    // Start is called before the first frame update
    void Start()
    {
        
       
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(GameManager.Instance.lana);

    }
}
