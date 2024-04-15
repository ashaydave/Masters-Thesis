using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDelayed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.PlayDelayed(Random.Range(10.0f, 20.0f));
    }

}
