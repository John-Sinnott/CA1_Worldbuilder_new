
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [Tooltip("Name of the scene to load. It must be listed in Build Settings.")]
    [SerializeField] private string nextSceneName = "level_2";

    public void LoadNextLevel()
    {
        // Unpause the game before loading the next level.
        Time.timeScale = 1f;

        Debug.Log("Loading next level: " + nextSceneName);

        SceneManager.LoadScene(nextSceneName);
    }
}