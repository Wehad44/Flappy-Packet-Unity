using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject selectLevelPanel;
    public GameObject mainMenuPanel;

    void Start()
    {
        int showSelectLevel = PlayerPrefs.GetInt("ShowSelectLevel", 0);

        if (showSelectLevel == 1)
        {
            selectLevelPanel.SetActive(true);
            mainMenuPanel.SetActive(false);
            PlayerPrefs.SetInt("ShowSelectLevel", 0);
        }
        else
        {
            selectLevelPanel.SetActive(false);
            mainMenuPanel.SetActive(true);
        }
    }
}
