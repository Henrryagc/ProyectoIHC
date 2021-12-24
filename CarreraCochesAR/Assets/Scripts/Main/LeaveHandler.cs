using agora_gaming_rtc;
using UnityEngine;

public class LeaveHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        IRtcEngine mrtcEngine = IRtcEngine.GetEngine(ApplicationModal.AppId);
        if (mrtcEngine != null)
        {
            Debug.Log("Leaving Channel");
            mrtcEngine.LeaveChannel();
        }
    }
}
