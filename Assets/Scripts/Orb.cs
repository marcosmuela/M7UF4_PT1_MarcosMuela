using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour, ICollectable
{
        public void OnCollected()
        {
        GameManager.gameManager.OrbCollected(1);
        Destroy(gameObject);
        }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
