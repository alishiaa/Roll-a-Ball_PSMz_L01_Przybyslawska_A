using UnityEngine;
using UnityEngine.SceneManagement;
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
}