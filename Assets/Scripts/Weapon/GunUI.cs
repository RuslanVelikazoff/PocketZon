using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GunUI : MonoBehaviour
{
    [SerializeField] 
    private Button fireButton;

    [SerializeField]
    private TextMeshProUGUI bulletText;

    [SerializeField] 
    private Gun gun;

    private void Start()
    {
        ButtonClickAction();
    }

    private void ButtonClickAction()
    {
        if (fireButton != null)
        {
            fireButton.onClick.RemoveAllListeners();
            fireButton.onClick.AddListener(() =>
            {
                gun.Fire();
            });
        }
    }

    public void SetBulletCount(int bulletCount)
    {
        bulletText.text = $"Патронов: {bulletCount}";
    }
}
