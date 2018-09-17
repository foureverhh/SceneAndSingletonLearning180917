using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private static Player _instance;

    public static Player Instance {
        get
        {
            if (_instance == null)
            {
                _instance = Instantiate(Resources.Load<GameObject>("Player").GetComponent<Player>());
            }
            return _instance;
        }
    }

    public int points = 0;

    private void Awake()
    {
       
        if(_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        } 
    }
    private void OnMouseDown()
    {
        points++;
    }
}
