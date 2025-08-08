using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashLoader : MonoBehaviour
{
    public float delayTime = 2.5f; // Seconds to wait

    void Start()
    {
        Invoke("LoadNextScene", delayTime);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("SampleScene"); // Replace with your main game scene name
    }
}
