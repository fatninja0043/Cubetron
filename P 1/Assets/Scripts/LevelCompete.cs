
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompete : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
