using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    public int startSceneID;

    public void StartGame()
    {
        SceneManager.LoadScene(startSceneID);
    }

    public void QuitGame()
    {
        Application.Quit();
        //only closes game in build, not editor
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
