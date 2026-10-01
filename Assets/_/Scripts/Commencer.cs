using UnityEngine;
using UnityEngine.SceneManagement;

public class Commencer : MonoBehaviour
{
    public string nomDeLaScene = "Niveau1"; // Nom exact ☝️

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}