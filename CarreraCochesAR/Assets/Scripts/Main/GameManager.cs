using UnityEngine;
using agora_gaming_rtc;

#if(UNITY_2018_3_OR_NEWER)
using UnityEngine.Android;
#endif

public class GameManager : MonoBehaviour
{

    private IRtcEngine mRtcEngine = null;
    private bool isInAgoraAudio = false;

    public MuteButton muteButton;

    public static string appID = "Agora app id";

    // Start is called before the first frame update

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;
    }

    void Start()
    {
#if (UNITY_2018_3_OR_NEWER)
        if (Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {

        }
        else
        {
            Permission.RequestUserPermission(Permission.Microphone);
        }
#endif

        mRtcEngine = IRtcEngine.GetEngine(ApplicationModal.AppId);
        // LoadAgoraKit();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ExitGame()
    { // MenuPage returnPage
        LeaveChannel();

    }

    public void LoadAgoraKit()
    {
        mRtcEngine = IRtcEngine.GetEngine(ApplicationModal.AppId);

        mRtcEngine.SetLogFilter(LOG_FILTER.DEBUG);
        // string rtcLogFile = LocalLogFilePath();
        // mRtcEngine.SetLogFile(rtcLogFile);
        // Debug.Log(string.Format("SetLogFile {0}", rtcLogFile));
        // Debug.Log(" SDK  version  =  " + IRtcEngine.GetSdkVersion());
        // mRtcEngine.SetChannelProfile(CHANNEL_PROFILE.GAME_FREE_MODE);

        mRtcEngine.EnableAudioVolumeIndication(200, 3);
        // LoadEngineCallbacks();
    }

    public void LeaveChannel()
    {
        if (isInAgoraAudio)
        {
            mRtcEngine.LeaveChannel();
        }
        isInAgoraAudio = false;
    }
    /*
    void LoadEngineCallbacks()
    {
        mRtcEngine.OnJoinChannelSuccess += EngineOnJoinChannelSuccess;
        mRtcEngine.OnLeaveChannel += EngineOnLeaveChannel;
        mRtcEngine.OnUserJoined += EngineOnUserJoined;
        mRtcEngine.OnUserOffline += EngineOnUserOffline;
        mRtcEngine.OnUserMuted += EngineOnMute;
        mRtcEngine.OnError += EngineOnError;
        mRtcEngine.OnWarning += EngineOnWarning;
    }

    public void UnLoadEngineCallbacks()
    {
        mRtcEngine.OnJoinChannelSuccess -= EngineOnJoinChannelSuccess;
        mRtcEngine.OnLeaveChannel -= EngineOnLeaveChannel;
        mRtcEngine.OnUserJoined -= EngineOnUserJoined;
        mRtcEngine.OnUserOffline -= EngineOnUserOffline;
        mRtcEngine.OnUserMuted -= EngineOnMute;
        mRtcEngine.OnError -= EngineOnError;
        mRtcEngine.OnWarning -= EngineOnWarning;
    }
    
    void EngineOnJoinChannelSuccess(string channelName, uint uid, int elapsed)
    {
        string joinSuccessMessage = string.Format(
            "joinChannel callback channel {0}, uid: {1}, elapsed: {2}",
            channelName, Convert.ToString(uid), Convert.ToString(elapsed));
        Debug.Log(joinSuccessMessage);

        // show mute button
        muteButton.SetHidden(false);
    }

    void EngineOnLeaveChannel(RtcStats stats)
    {
        string leaveChannelMessage = string.Format(
            "leaveChannel callback duration {0}, tx: {1}, rx: {2}, tx kbps: {3}, rx kbps: { 4}", 
        stats.duration, 
        stats.txBytes, stats.rxBytes, stats.txKBitRate, stats.rxKBitRate);
        Debug.Log(leaveChannelMessage);
    }

    void EngineOnUserJoined(uint uid, int elapsed)
    {
        string userJoinedMessage = string.Format(
            "onUserJoined callback uid {0} {1}", uid, elapsed);
        Debug.Log(userJoinedMessage);
    }

    public void MuteSelf(bool shouldMute)
    {
        mRtcEngine.MuteLocalAudioStream(shouldMute);
    }
    void EngineOnMute(uint uid, bool muted)
    {
        string userMutedMessage = string.Format(
            "onUserMuted callback uid {0} {1}", uid, muted);
        Debug.Log(userMutedMessage);
    }

    void EngineOnError(int error, string msg)
    {
        AlertString("Engine error: " + error);
    }

    void EngineOnWarning(int warn, string msg)
    {
        AlertString("Engine warning: " + warn);
    }*/
}
