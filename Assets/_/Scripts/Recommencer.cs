using UnityEngine;
using UnityEngine.SceneManagement;

public class Recommencer : MonoBehaviour
{
    public string nomDeLaScene_1 = "Niveau1"; // Nom exact ☝️

    public void ChangeLaScene_1()
    {
        SceneManager.LoadScene(nomDeLaScene_1);
    }
}