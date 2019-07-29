using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//will load new scenes and also restart the game if we died

public class GameManager : MonoBehaviour
{
    bool end = false;

    public void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1) ;
    }


    //Avengers!

    //public to be accessed from outside classes
    public void EndGame()
    {
        if(end == false)
        {
            end = true;
            Invoke("Restart",1);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }





}
