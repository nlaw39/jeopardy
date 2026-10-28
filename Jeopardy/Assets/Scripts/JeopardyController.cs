using UnityEngine;
using TMPro;

public class JeopardyController : MonoBehaviour
{
    [Header("Host UI")]
    [SerializeField] TMP_InputField questionInput;

    [Header("Audience UI")]
    [SerializeField] GameObject idlePanel;
    [SerializeField] GameObject questionPanel;
    [SerializeField] TMP_Text questionText;

    void Start()
    {
        // Turn on any extra monitors (only has an effect in builds)
        for (int i = 1; i < Display.displays.Length; i++)
            Display.displays[i].Activate();

        ShowBoard();
    }

    public void ShowQuestion()
    {
        Debug.Log("ShowQuestion called");
        questionText.text = questionInput.text;
        idlePanel.SetActive(false);
        questionPanel.SetActive(true);
    }

    public void ShowBoard()
    {
        questionPanel.SetActive(false);
        idlePanel.SetActive(true);
    }
}