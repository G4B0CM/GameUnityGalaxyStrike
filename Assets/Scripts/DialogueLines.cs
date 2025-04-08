using TMPro;
using UnityEngine;

public class DialogueLines : MonoBehaviour
{
    [SerializeField] TMP_Text dialogueText;
    [SerializeField] string[] timelineTextLINes;

    int currentLine = 0;
    public void NextDialogueLine()
    {
        currentLine++;
        dialogueText.text = timelineTextLINes[currentLine];
    }
}
