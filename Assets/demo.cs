using UnityEngine;

public class demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var vInit = Vuforia.VuforiaARController.Instance;
        vInit.RegisterVuforiaInitializedCallback(OnVuforiaStarted);

    }

    public void OnVuforiaStarted()
    {
        Vuforia.CameraDevice.Instance.SetFocusMode(Vuforia.CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

}
