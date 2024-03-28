using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LosePanel : MonoBehaviour
{
    [SerializeField] 
    private GameObject losePanel;

    [SerializeField]
    private Button restartButton;

    private void Start()
    {
        ButtonClickAction();
    }

    public void OpenLosePanel()
    {
        losePanel.SetActive(true);
    }

    private void ButtonClickAction()
    {
        if (restartButton != null)
        {
            restartButton.onClick.RemoveAllListeners();
            restartButton.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(0);
            });
        }
    }
}
