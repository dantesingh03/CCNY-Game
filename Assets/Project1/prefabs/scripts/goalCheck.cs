using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalCheck : MonoBehaviour
{
    public gameManager myManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == "enemy")
        {
            myManager.GameOver();
        }
    }
}
