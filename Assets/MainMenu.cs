using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickNewGame()
    {
        Debug.Log("Game start");
        SceneManager.LoadScene("Second Stage");

    }
    public void OnClickTrain()
    {
        Debug.Log("Traing");
        SceneManager.LoadScene("Training Center");


    }
    public void OnClickMain()
    {
        Debug.Log("Main");
        SceneManager.LoadScene("Main");


    }

    public void OnClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying=false;
#else
        Application.Quit();
#endif
    }
}
