using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followtransform;
    public BoxCollider2D mapbounds;

    float Xmin, Xmax, Ymin, Ymax;
    float camY, camX;
    float CamOrthSize;
    float CameraRatio;
    private Camera MainCam;
    // Start is called before the first frame update
    void Start()
    {
        Xmin = mapbounds.bounds.min.x;
        Xmax = mapbounds.bounds.max.x;
        Ymin = mapbounds.bounds.min.y;
        Ymax = mapbounds.bounds.max.y;
        MainCam = GetComponent<Camera>();
        CamOrthSize = MainCam.orthographicSize;
        CameraRatio = (Xmax + CamOrthSize) / 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        camY = Mathf.Clamp(followtransform.position.y, Ymin + CamOrthSize, Ymax - CamOrthSize);
        camX = Mathf.Clamp(followtransform.position.x, Xmin + CamOrthSize, Xmax - CamOrthSize);
        this.transform.position = new Vector3(camX, camY, this.transform.position.z);
    }
}
