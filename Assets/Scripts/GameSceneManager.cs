using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    [SerializeField] float seconds = 1f;
    public void ReloadLevel()
    {
        StartCoroutine(ReloadLevelRoutine());
    }
    IEnumerator ReloadLevelRoutine()
    {
        yield return new WaitForSeconds(seconds);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
