using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour {

    AsyncOperation async;

    private void Start()
    {
        Player.Instance.transform.position = Vector3.zero;

        Debug.Log("Points are: " + Player.Instance.points);
        Debug.Log("Scene " + SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name == "Scene1")
        {
            async = SceneManager.LoadSceneAsync("Scene2");
            async.allowSceneActivation = false;
        }
        else if (SceneManager.GetActiveScene().name == "Scene2")
        {
            async = SceneManager.LoadSceneAsync("Scene1");
            async.allowSceneActivation = false;
        }
    }

    private void OnMouseDown()
    {
        /*
        if(SceneManager.GetActiveScene().name == "Scene1")
        {
            SceneManager.LoadScene("Scene2");
        }else if(SceneManager.GetActiveScene().name == "Scene2")
        {
            SceneManager.LoadScene("Scene1");
        }
        */
        async.allowSceneActivation = true;
        Debug.Log("Points are: "+Player.Instance.points);

    }
}
