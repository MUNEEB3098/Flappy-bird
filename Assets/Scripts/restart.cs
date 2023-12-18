using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
     GameObject pauses;
    public static bool pase;
    public void Restart() 
    {
        
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
        
    }
    public void home()
    {
        
        UnityEngine.SceneManagement.SceneManager.LoadScene("Home");

    }
    private void Start()
    {
        
        pauses.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            if (pase)
            {
                
                pase = false;
            }
            else 
            {
                
                pase = true;
            }
        }
        if(pase)
            pause();
        else
            resume();
    }
    public void pause() 
    {
        
        pauses.SetActive(true);
        Time.timeScale = 0f;
    }
    public void resume() 
    {
        pauses.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Quit() 
    {
        
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                    Application.Quit();
        #endif
    }

}
