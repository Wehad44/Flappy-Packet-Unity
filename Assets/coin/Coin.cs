
/*

using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip collectSound;
    private AudioSource audioSource;
    private bool isCollected = false;

    void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("Logic").GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isCollected && collision.gameObject.CompareTag("Player"))
        {
            isCollected = true;
            audioSource.PlayOneShot(collectSound);
            LogicScript logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
            logic.AddCoin();
            Destroy(gameObject);
        }
    }
}



using UnityEngine;
public class Coin : MonoBehaviour
{
    [SerializeField]  private int value;
    private bool hasTriggered;

    private CoinManager coinManager;
    private void Start()
    {
        coinManager = CoinManager.instance;
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player") && hasTriggered)
        {
            hasTriggered = true;
           coinManager.ChangeCoins(value);
            Destroy(gameObject);
        }

    }

}*/



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
