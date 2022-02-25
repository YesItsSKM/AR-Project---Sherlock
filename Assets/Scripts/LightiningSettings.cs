using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightiningSettings : MonoBehaviour
{
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        transform.localEulerAngles = new Vector3(50, 180, 0);
        RenderSettings.skybox = mat;
    }
}
