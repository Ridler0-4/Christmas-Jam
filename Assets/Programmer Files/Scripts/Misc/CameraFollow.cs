using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followtransform;
    public BoxCollider2D mapbounds;

    private Camera MainCam;

    float Xmin, Xmax, Ymin, Ymax;
    private float camx;
    private float camy;
    // Start is called before the first frame update
    void Start()
    {
        Xmin = mapbounds.bounds.min.x;
        Xmax = mapbounds.bounds.max.x;
        Ymin = mapbounds.bounds.min.y;
        Ymax = mapbounds.bounds.max.y;
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
