using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartest : MonoBehaviour
{
    float speed = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);
        //transform.position += new Vector3(speed, 0, 0);
        //transform.localposition += new Vector3(speed, 0, 0);
    }
}
