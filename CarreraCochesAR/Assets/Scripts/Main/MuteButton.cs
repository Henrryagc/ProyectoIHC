using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite mutedImage;
    public Sprite unmutedImage;

    Image myImageComponent;
    private bool isMuted = false;

    void Start()
    {
        myImageComponent = GetComponent<Image>();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void SetHidden(bool hidden)
    {
        if (!hidden)
        {
            isMuted = false;
            myImageComponent.sprite = unmutedImage;
        }

        gameObject.SetActive(!hidden);
    }

    public void MuteClicked()
    {
        isMuted = !isMuted;
        myImageComponent.sprite = isMuted ? mutedImage : unmutedImage;

        //  GameManager gameManager = GameManager.s_Instance;
        //  gameManager.MuteSelf(isMuted);
    }
}
