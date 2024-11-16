using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class buttons : MonoBehaviour
{
    public GameObject Menu;
    public GameObject OptionsPanel;
    public void StartGame()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void Option(bool isActive)
    {
        OptionsPanel.SetActive(isActive);
    }
    public void ExitGame()
    {
        
        
            Application.Quit();
        
      
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void EndGame()
    {   
        
            SceneManager.LoadScene("EndGame");
        
    }
}