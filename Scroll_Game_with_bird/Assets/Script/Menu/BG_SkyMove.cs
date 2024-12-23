using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_SkyMove : MonoBehaviour
{
    private Transform[] BG= new Transform[3];
    private Vector3 start, end;
    private float[] speed = new float[3];

    // Start is called before the first frame update
    void Start()
    {
        BG[0] = this.transform.Find("Back");
        BG[1] = this.transform.Find("Cloud_1");
        BG[2] = this.transform.Find("Cloud_2");

        BG[0].position = new Vector3(0, 0, 4);
        BG[1].position = new Vector3(0, 0, 4);
        BG[2].position = new Vector3(0, 0, 4);

        speed[0] = 0.6f;
        speed[1] = 0.8f;
        speed[2] = 1.0f;

        start = new Vector3(0, 0, 4);
        end = new Vector3(21.5f, 0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 3; ++i)
        {
            BG[i].position += Vector3.right * Time.deltaTime * speed[i];
            if (BG[i].position.x >= end.x) BG[i].position = start;
        }
    }
}
