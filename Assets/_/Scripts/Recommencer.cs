using UnityEngine;
using UnityEngine.SceneManagement;

public class Recommencer : MonoBehaviour
{
    public string nomDeLaScene = "Menu"; // Nom exact ☝️

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}