using UnityEngine;
using UnityEngine.SceneManagement;

public class Histoire : MonoBehaviour
{
    public string nomDeLaScene = "Histoire"; // Nom exact ☝️

    public void LireLHistoire()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}