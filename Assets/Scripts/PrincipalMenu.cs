using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrincipalMenu : MonoBehaviour
{
    public void StartTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
