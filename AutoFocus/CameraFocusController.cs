using UnityEngine;
using System.Collections;
using Vuforia;

public class Autofocus : MonoBehaviour {

    private bool mVuforiaStarted = false;

    void Start () 
    {
        VuforiaARController vuforia = VuforiaARController.Instance;
        if (vuforia != null)
            vuforia.RegisterVuforiaStartedCallback(StartAfterVuforia);
    }

    private void StartAfterVuforia()
    {
        mVuforiaStarted = true;
        SetAutofocus();
    }

    void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
          
            if (mVuforiaStarted)
            {
                SetAutofocus(); 
              
            }
        }
    }

    private void SetAutofocus()
    {
        if (CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO))
        {
            Debug.Log("Autofocus");
        }
        else
        {
            Debug.Log("Autpfocusul nu este suportat");
        }
    }
}
