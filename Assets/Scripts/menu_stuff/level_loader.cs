using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_loader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void loadMenuScene()
    {
        SceneManager.LoadScene(0);
    }
    public void loadGameScene()
    {
        SceneManager.LoadScene(1);
    }
    public void loadControlsScene()
    {
        SceneManager.LoadScene(7);
    }
    public void loadCreditsScene()
    {
        SceneManager.LoadScene(8);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
