using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public LanguageData Catalan;
    public LanguageData Castellano;
    public LanguageData Ingles;

    public GameObject mainPanel;
    public GameObject playerPanel;
    public Text playerDescriptionText;
    public Image playerImage;

    public Sprite Imogen;
    public Sprite Cactus;
    public Sprite Nova;
    public Sprite Gato;

    private LanguageData currentLanguage;
    private int currentPlayerIndex = 1;

    private Sprite[] playerSprites;

    void Start()
    {
        SetLanguage(Castellano); // Corrección: se usaba "spanish", que no existe

        playerSprites = new Sprite[] { null, Imogen, Cactus, Nova, Gato }; // Usamos índice 1-4 para coincidir con el switch

        playerPanel.SetActive(false);
    }

    public void SetLanguage(LanguageData language)
    {
        currentLanguage = language;
        UpdatePlayerDescription(currentPlayerIndex);
    }

    private void UpdatePlayerDescription(int playerIndex)
    {
        switch (playerIndex)
        {
            case 1:
                playerDescriptionText.text = currentLanguage.player1Description;
                break;
            case 2:
                playerDescriptionText.text = currentLanguage.player2Description;
                break;
            case 3:
                playerDescriptionText.text = currentLanguage.player3Description;
                break;
            case 4:
                playerDescriptionText.text = currentLanguage.player4Description;
                break;
            default:
                playerDescriptionText.text = "";
                break;
        }
    }

    public void ShowPlayerInfo(int playerIndex)
    {
        mainPanel.SetActive(false);
        playerPanel.SetActive(true);

        currentPlayerIndex = playerIndex;

        UpdatePlayerDescription(playerIndex);

        if (playerIndex >= 1 && playerIndex <= 4)
        {
            playerImage.sprite = playerSprites[playerIndex];
        }
    }

    public void HidePlayerInfo()
    {
        mainPanel.SetActive(true);
        playerPanel.SetActive(false);
    }
}