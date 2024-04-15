using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class AssignScriptsOnLook : MonoBehaviour
{
    public LayerMask layerMask;
    public LayerMask playerLayer;

    /// <summary>
    /// 
    /// </summary>
    private void Update()
    {
        RaycastHit hit;

        // Cast a ray from the center of the screen
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        // Exclude player layer from the raycast
        layerMask &= ~playerLayer;
        // Check if the ray hits any collider in the specified layer mask
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {

            if (hit.collider.gameObject.GetComponent<LibPdInstance>() == null)
            {
                hit.collider.gameObject.AddComponent<LibPdInstance>();
            }

            if (hit.collider.gameObject.GetComponent<SteamAudio.SteamAudioSource>() == null)
            {
                hit.collider.gameObject.AddComponent<SteamAudio.SteamAudioSource>();
            }

            //if (hit.collider.gameObject.GetComponent<PdPatchManager>() == null)
            //{
            //    hit.collider.gameObject.AddComponent<PdPatchManager>();
            //}
        }
    }
}
