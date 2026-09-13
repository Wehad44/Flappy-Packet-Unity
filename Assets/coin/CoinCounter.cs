/*using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public static int coinCount = 0; 
    public Text coinText;

    private void Start()
    {
        coinCount = 0;
        UpdateUI();
    }


    public void AddCoin()
    {
        coinCount++;
        UpdateUI();
        PlayerPrefs.SetInt("Coins", coinCount);
    }// add


    private void UpdateUI()
    {
        coinText.text = "Coins: " + coinCount.ToString();
    }
}
*/

using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public static int coinCount = 0;
    public Text coinText;

    private void Start()
    {
        coinCount = PlayerPrefs.GetInt("Coins", 0); 
        UpdateUI();
    }

    public void AddCoin()
    {
        coinCount++;
        UpdateUI();
        PlayerPrefs.SetInt("Coins", coinCount);
    }

    private void UpdateUI()
    {
        coinText.text = "Coins: " + coinCount.ToString();
    }
}

