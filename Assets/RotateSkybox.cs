using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class RotateSkybox : MonoBehaviour
{
    /*
    public float skyboxSpeed = 1.0f;
    private float rotation = 0.0f;
    private float time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        rotation = time * skyboxSpeed;
        if (rotation > 360) { 
            rotation = 0.0f;
            time = 0.0f;
        }
        RenderSettings.skybox.SetFloat ("_Rotation", rotation);
    }
    */
    public VolumeProfile volume;
    private HDRISky hdriSky;
    private float hdriRotationSpeed = 2;
    private float rotation = 0.0f;
    private float time = 0.0f;

    void Start()
    {
        if (volume) {
            volume.TryGet(out hdriSky);
            hdriSky.rotation.Override(0.0f);
        }
    }

    void Update()
    {
        time += Time.deltaTime;
        rotation = time * hdriRotationSpeed;
        if (rotation > 360)
        {
            rotation = 0.0f;
            time = 0.0f;
        }
        if (hdriSky) { 
            hdriSky.rotation.Override(rotation);
        }
    }
}
