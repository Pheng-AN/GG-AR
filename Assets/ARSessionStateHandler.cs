using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARSessionStateHandler : MonoBehaviour
{
    void Update()
    {
        // Check the ARSession state
        var sessionState = ARSession.state;

        // Handle Earth state error or other session issues
        if (sessionState != ARSessionState.SessionTracking)
        {
            Debug.LogError("Earth not authorized or AR Session not tracking. Current state: " + sessionState);
        }
    }
}
