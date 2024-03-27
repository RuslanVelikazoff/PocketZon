using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    private int record;
    [SerializeField]
    private int score;

    [SerializeField]
    private TextMeshProUGUI recordText;
    [SerializeField] 
    private TextMeshProUGUI scoreText;

    private void Start()
    {
        SetRecordText();
        SetScoreText();
    }

    public void AddScore()
    {
        score += 1;

        if (score > record)
        {
            record = score;
            SetScoreText();
            SetRecordText();
        }
        else
        {
            SetScoreText();
        }
    }

    private void SetScoreText()
    {
        scoreText.text = $"Счёт: {score}";
    }

    private void SetRecordText()
    {
        if (record == 0)
        {
            recordText.text = "";
        }
        else
        {
            recordText.text = $"Рекорд: {record}";
        }
    }
}
