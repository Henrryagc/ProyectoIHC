using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartData : MonoBehaviour
{
    public static StartData startdataScene;
    public TMP_InputField nameInput;
    public Toggle toggleConductor;
    public Toggle toggleCopiloto;

    public string playerName;
    public int playerStatus;

    private void Awake()
    {
        if (startdataScene == null)
        {
            startdataScene = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OnSetPlayerName()
    {
        playerName = nameInput.text;
        int playerState = 0;
        if (toggleCopiloto.isOn)
        {
            playerState = 1;
        }
        playerStatus = playerState;
        SceneManager.LoadSceneAsync("BlankAR");
    }
}
