
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenuBehaviour : MonoBehaviour
{
    /// <summary>
    /// load new scene when called
    /// </summary>
    /// <param name="levelName"> name of level we want to go to</param>
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
