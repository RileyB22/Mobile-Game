
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuBehaviour : MonoBehaviour
{
    /// <summary>
    /// load new scene when called
    /// </summary>
    /// <param name="levelName"> name of level we want to go to</param>

    public TextMeshProUGUI highScoreText;
   // public GameObject controlPanel;

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("score", 0);
        GetAndDisplayScore();
    }

    public void Start()
    {
        //show hs on start
        GetAndDisplayScore();
    }

    private void GetAndDisplayScore()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("score").ToString();
    }
}
