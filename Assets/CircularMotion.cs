using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    private float time = 0.0f;
    public float speed = 0.0f;
    private float x;
    private float y;
    private float z;

    // Start is called before the first frame update
    void Start()
    {
        x = transform.rotation.x;
        y = -180f;
        z = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        //time += Time.deltaTime;
        //y += time * speed;
        //staly obrot
        time = 0;
        time += Time.deltaTime;
        y -= time * speed;

        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, y, transform.eulerAngles.z);
        //this.transform.Rotate(0, -1 * speed, 0);
    }
}
