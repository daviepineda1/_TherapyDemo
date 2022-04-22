using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{

    [SerializeField] ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Is started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        // Debug.Log("Is Collided");
        if(other.gameObject.tag == "Hand")
        {
            Debug.Log("Is Hand");
            scoreManager.AddPoint();
            Destroy (gameObject);
        }

    }
}
