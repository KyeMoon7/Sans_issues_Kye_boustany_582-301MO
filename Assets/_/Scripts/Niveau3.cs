using UnityEngine;
using UnityEngine.SceneManagement;

public class Niveau3 : MonoBehaviour
{
    public string nomDeLaScene2 = "Niveau3"; // Nom exact ☝️

    public void ChangeLaScene2()
    {
        SceneManager.LoadScene(nomDeLaScene2);
    }
}