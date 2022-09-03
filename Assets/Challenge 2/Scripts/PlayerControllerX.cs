using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public static float time; 
    public float timeLastPass = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            time = Time.time; // The time at the beginning of this frame (Read Only). This is the time in seconds since the start of the game.
            float deltaTime = time - timeLastPass; //The time since the spacebar was successfully used
            // Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            if (deltaTime > 0.5f)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeLastPass = time;
            }
        }

        
    }
}

