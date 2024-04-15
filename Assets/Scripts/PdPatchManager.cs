using UnityEditor;
using UnityEngine;

[System.Serializable]
public struct PatchInstances
{
#if UNITY_EDITOR
    public DefaultAsset birdPatch;
    public DefaultAsset jetEnginePatch;
    public DefaultAsset carEnginePatch;
    public DefaultAsset clockPatch;
    public DefaultAsset ballPatch;
    public DefaultAsset cellPhonePatch;
    public DefaultAsset telephoneBellPatch;
    public DefaultAsset mouseClickPatch;
#endif
}

public class PdPatchManager : MonoBehaviour
{
    //public static PdPatchManager Instance;
    public PatchInstances patches;

    /// <summary>
    /// 
    /// </summary>
    //private void Awake()
    //{
    //    if (Instance == null)
    //    {
    //        Instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //}


    /// <summary>
    /// 
    /// </summary>
    /// <param name="objectName"></param>
    public void HandleClassifiedObject(string objectName)
    {
        objectName = objectName.Trim();
        Debug.Log("Classified object received: " + objectName);
        // Determine the patch to load based on the object name
        //DefaultAsset patchAsset = GetPatchAsset(objectName);



        LibPdInstance[] libPdInstances = FindObjectsOfType<LibPdInstance>();
        foreach (LibPdInstance instance in libPdInstances)
        {
            // Set the patch asset in the LibPdInstance component
            instance.ReceiveObjectName(objectName);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="objectName"></param>
    /// <returns></returns>
    public DefaultAsset GetPatchAsset(string objectName)
    {
        objectName = objectName.Trim();
        Debug.Log("Get patched " + objectName);
        switch (objectName)
        {
            case "bird":
                return patches.birdPatch;
            case "aeroplane":
                return patches.jetEnginePatch;
            case "traffic light":
                return patches.jetEnginePatch;
            case "tv monitor":
                return patches.jetEnginePatch;
            case "car":
                return patches.carEnginePatch;
            case "clock":
                return patches.clockPatch;
            case "sports ball":
                return patches.mouseClickPatch;
            case "surfboard":
                return patches.mouseClickPatch;
            case "banana":
                return patches.mouseClickPatch;
            case "cell phone":
                return patches.cellPhonePatch;
            case "remote":
                return patches.cellPhonePatch;
            case "mouse":
                return patches.mouseClickPatch;
            case "telephone":
                return patches.telephoneBellPatch;
            default:
                Debug.Log("Case break");
                return null;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="patchAsset"></param>
    //void SetPatch(DefaultAsset patchAsset)
    //{
    //    // Check if the patch asset is assigned
    //    if (patchAsset != null)
    //    {
    //        // Set the patch name and directory in the LibPdInstance component
    //        libPdInstance.patchName = patchAsset.name;
    //        libPdInstance.patchDir = Application.streamingAssetsPath;
    //        Debug.Log("Assigned patch: " + patchAsset.name);
    //    }
    //    else
    //    {
    //        Debug.LogWarning("Patch asset not assigned!");
    //    }
    //}
}

