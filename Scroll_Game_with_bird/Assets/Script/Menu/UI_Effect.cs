using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Effect : MonoBehaviour
{
    public GameObject btn;
    public Vector3 point;
    public Transform title_pos;

    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.Find("Buttons");
        btn.transform.localPosition = new Vector3(0, -80, 0);
        btn.SetActive(false);

        point = new Vector3(0, 80, 0);

        title_pos = this.transform.Find("Text_Title");
        title_pos.localPosition = new Vector3(0, 300, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //distance
        if (Mathf.Abs(title_pos.localPosition.y - point.y) >= 0.4f)
            title_pos.localPosition = Vector3.Lerp(title_pos.localPosition, point, 0.02f);
        else
        {
            btn.SetActive(true);
            this.GetComponent<UI_Effect>().enabled = false;
        }
    }
}
