using UnityEngine;

public class MusicPlayerScrip : MonoBehaviour
{
    private void Start()
    {
        int numOfMusicPlayers = FindObjectsByType<MusicPlayerScrip>(FindObjectsSortMode.None).Length;

        if (numOfMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
