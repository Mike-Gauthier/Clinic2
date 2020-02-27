using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    
    public string sceneName;

    //This Script will be attached to the Box that will allow the Player to change scenes. The scene name must be inputted manually on each box, and the only button that can be used is the Space Bar. 
    //Make sure each scene is in the box at the top of the Build Settings Window.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
