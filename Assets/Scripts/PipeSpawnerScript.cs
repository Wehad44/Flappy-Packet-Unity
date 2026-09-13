using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 2;


   public GameObject coin;
    void Start()
    {
        spawnPipe();

        }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
    // spawnPipe();
    //
    // }


    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

    }
    /*
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Vector3 pipePos = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);
        GameObject newPipe = Instantiate(pipe, pipePos, transform.rotation);


        Vector3 coinPos = new Vector3(pipePos.x, pipePos.y + 2.5f, 0);

        Instantiate(coin, coinPos, Quaternion.identity);




        
    }
    */
    
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Vector3 pipePos = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);

        GameObject newPipe = Instantiate(pipe, pipePos, transform.rotation);

        
        float gapY = pipePos.y;
        float coinY = gapY + 0.5f;

        Vector3 coinPos = new Vector3(pipePos.x, coinY, 0);
        GameObject newCoin = Instantiate(coin, coinPos, Quaternion.identity);

      
        newCoin.transform.parent = newPipe.transform;
    }


    




}
