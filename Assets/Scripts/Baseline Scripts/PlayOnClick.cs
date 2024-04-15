using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    private AudioSource audioSource;
    private Collider objCollider;
    private bool isPlaying = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        objCollider = GetComponent<Collider>();
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0) && !audioSource.isPlaying)
        {
            // Cast a ray from the camera to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits the collider of the mouse GameObject
            if (Physics.Raycast(ray, out hit) && hit.collider == objCollider)
            {
                audioSource.PlayOneShot(audioSource.clip);
            }
        }

        if (Input.GetMouseButtonDown(1) && audioSource.isPlaying)
        {
            // Cast a ray from the camera to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits the collider of the mouse GameObject
            if (Physics.Raycast(ray, out hit) && hit.collider == objCollider)
            {
                audioSource.Stop();
            }
        }
    }
}

