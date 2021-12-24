using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject camera2;
    public GameObject camera3;
    public bool camerActive = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnActiveCamera()
    {
        camera2.SetActive(camerActive);
        camerActive = !camerActive;
        camera3.SetActive(camerActive);
    }
}
