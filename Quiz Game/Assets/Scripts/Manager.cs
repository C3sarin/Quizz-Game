using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject[] levels;
    private int currentLevelIndex = 0;

    public void LoadNextLevel()
    {
        currentLevelIndex++;
        if (currentLevelIndex < levels.Length)
        {
            levels[currentLevelIndex - 1].SetActive(false);
            levels[currentLevelIndex].SetActive(true);
        }
        else
        {
            Debug.Log("¡Has completado todos los niveles!");
            // Aquí puedes manejar la finalización del juego, como mostrar una pantalla de fin de juego
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
