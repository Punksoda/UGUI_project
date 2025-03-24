using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    public Button btnStatus;
    public Button btnInven;
    public TMP_Text playerNameText;
    public TMP_Text playerDescriptionText;
    public TMP_Text playerGoldText;
    public TMP_Text playerLevelText;
    public TMP_Text playerExpText;

    public void Start()
    {
        btnStatus.onClick.AddListener(OpenStatus);
        btnInven.onClick.AddListener(OpenInventory);
        SetData();
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.ShowUI(UIManager.Instance.mainMenu.gameObject);
    }

    public void OpenStatus()
    {
        UIManager.Instance.ShowUI(UIManager.Instance.status.gameObject);
    }

    public void OpenInventory()
    {
        UIManager.Instance.ShowUI(UIManager.Instance.inventory.gameObject);
    }

    public void SetData()
    {
        Character player = GameManager.Instance.PlayerCharacter;
        playerNameText.text = $"{player.Name}";
        playerDescriptionText.text = $"{player.Description}";
        playerLevelText.text = $"{player.Level}";
        playerGoldText.text = $"{player.Gold}G";
        playerExpText.text = $"{player.Exp} / 150 ";
    }
}
