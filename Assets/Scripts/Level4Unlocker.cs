using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Level4Unlocker : MonoBehaviour
{
    public int requiredCoins = 20; 
    public Button level4Button; 
    public string level4SceneName = "LEVEL4";

    public GameObject lockedPanel; 

    void Start()
    {
        int currentCoins = PlayerPrefs.GetInt("Coins", 0);
        level4Button.interactable = currentCoins >= requiredCoins;

        if (currentCoins >= requiredCoins)
        {
            level4Button.onClick.AddListener(LoadLevel4);
        }
        else
        {
            level4Button.onClick.AddListener(ShowLockedPanel);
        }

        lockedPanel.SetActive(false); 
    }

    void LoadLevel4()
    {
        SceneManager.LoadScene(level4SceneName);
    }

    void ShowLockedPanel()
    {
        lockedPanel.SetActive(true);
        Invoke("HideLockedPanel", 2.5f);
    }

    void HideLockedPanel()
    {
        lockedPanel.SetActive(false);
    }
}

