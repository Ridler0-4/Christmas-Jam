using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followtransform;

    private Camera MainCam;

    private float camx;
    private float camy;
    // Start is called before the first frame update
    void Start()
    {
        MainCam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        camx = followtransform.position.x;
        camy = followtransform.position.y;
        this.transform.position = new Vector3(camx, camy, -8);
    }
}
