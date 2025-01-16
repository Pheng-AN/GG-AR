using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARCoreConfig : MonoBehaviour
{
    [SerializeField] private ARSession arSession;

    void Start()
    {
        // Ensure the AR session is available
        if (arSession == null)
        {
            Debug.LogError("ARSession is not assigned.");
            return;
        }

        // Apply configuration
        ConfigureARSession();
    }

    void ConfigureARSession()
    {
        // Configure session for the latest camera image
        ARCameraManager cameraManager = FindObjectOfType<ARCameraManager>();

        if (cameraManager != null)
        {
            Debug.Log("AR Session configured for the latest camera image.");
            // If additional configuration is needed, modify it here
        }
        else
        {
            Debug.LogError("ARCameraManager not found.");
        }
    }
}
