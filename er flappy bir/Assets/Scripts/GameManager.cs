using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public sealed class GameManager
    {
        private readonly static GameManager _instance = new GameManager();

        private GameManager()
        {


        }

        public static GameManager Instance
        {
            get
            {
                return _instance;
            }
        }
    
        public void L_()
        {

          Debug.Log("Hola");
         

        }
        public float Pa_ = 0;

        public int R_ = 0;

        public float lana= 0.0f;
        
    }

