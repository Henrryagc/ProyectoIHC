using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BlankAR : MonoBehaviour
{
    public TextMeshProUGUI displayName;


    public GameObject cameraConductor;
    public GameObject cameraCopiloto;
    public Button button;

    public void Awake()
    {
        displayName.text = StartData.startdataScene.playerName;

        if (StartData.startdataScene.playerStatus == 1)
        {
            cameraCopiloto.SetActive(true);
            cameraConductor.SetActive(false);
            button.gameObject.SetActive(true);
        }
    }
}
