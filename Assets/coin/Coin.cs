


using UnityEngine;

public class Coin : MonoBehaviour
{
    private CoinCounter counter;

    void Start()
    {
        counter = GameObject.FindObjectOfType<CoinCounter>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (counter != null)
            {
                counter.AddCoin();
            }
            Destroy(gameObject);
        }
    }




}
