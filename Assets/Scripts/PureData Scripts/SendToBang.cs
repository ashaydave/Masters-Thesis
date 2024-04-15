using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SendToBang : MonoBehaviour
{
    public LibPdInstance pdPatch;
    private Collider objCollider;
    private AudioSource audioSource;

    private void Update()
    {
        pdPatch = GetComponent<LibPdInstance>();
        objCollider = GetComponent<Collider>();

        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the camera to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits the collider of the mouse GameObject
            if (Physics.Raycast(ray, out hit) && hit.collider == objCollider)
            {
                pdPatch.SendBang("start");
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            // Cast a ray from the camera to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits the collider of the mouse GameObject
            if (Physics.Raycast(ray, out hit) && hit.collider == objCollider)
            {
                pdPatch.SendBang("start");
                StartCoroutine(StopSound());
                
            }
        }
    }

    IEnumerator StopSound()
    {
        yield return new WaitForSeconds(1);
        pdPatch.SendBang("stop");
    }
}
