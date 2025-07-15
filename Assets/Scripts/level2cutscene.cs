using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderSignal : MonoBehaviour
{
    public string nextSceneName;

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
