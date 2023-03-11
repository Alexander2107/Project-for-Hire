using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame22: MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    float rndm;
    Vector2 wts;
    [SerializeField]
    private float spawnRa = 2f;
    float nextSp = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSp)
        {
            nextSp = Time.time + spawnRa;
            rndm = Random.Range(-4.36f, 31.89f);
            wts = new Vector2(rndm, transform.position.y);
            Instantiate(obj, wts, Quaternion.identity);
        } 
    }
}
