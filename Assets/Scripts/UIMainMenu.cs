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
    public TMP_Text playerCritText;
    public TMP_Text playerHealthText;
    public TMP_Text playerAttackText;
    public TMP_Text playerDefenseText; 

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
        playerCritText.text = $"{player.Crit}";
        playerDefenseText.text = $"{player.Def}";
        playerCritText.text = $"{player.Crit}";
        playerHealthText.text = $"{player.Hp}";
        playerAttackText.text = $"{player.Atk}";

    }
}
