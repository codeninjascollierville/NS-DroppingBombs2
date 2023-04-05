using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private FallingBombs Spawner;

    void Awake()
    {
        Spawner = GameObject.Find("Spawner").GetComponent<FallingBombs>();
    }

    // Start is called before the first frame update
    void Start()
    {
       Spawner.active = false; 
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.anyKeyDown)
       {
        Spawner.active = true;
       }
    }
}
