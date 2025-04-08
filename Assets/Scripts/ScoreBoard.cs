using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] TMP_Text scoreBoardText;
    int score = 0;

    public void IncreaseSocre(int amount)
    {
        score += amount;
        scoreBoardText.text = score.ToString();
    }
}
