
/*using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }






}
*/





using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    public AudioClip flapSound;
    public AudioClip hitSound;
    private AudioSource audioSource;
    public AudioClip passSound;   


    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            audioSource.PlayOneShot(flapSound);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive)
        {
            audioSource.PlayOneShot(hitSound);
            logic.gameOver();
            birdIsAlive = false;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Pipe"))
        {
            audioSource.PlayOneShot(passSound); 
        }
    }
    

   


} 







