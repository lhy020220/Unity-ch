using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamema : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        //car = GameObject.Find("car");
        //flag = GameObject.Find("flag");
        //distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        if (car == null) return;
        if (flaog == null) return;
        if (distance == null) return;
        float length = flag.transform.position.x - car.transform.position.x;
        distance.GetComponent<TextMeshProUGUI>().text = "Distance :" + length.ToString("F2") + "m";
    }
}
