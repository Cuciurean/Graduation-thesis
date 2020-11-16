using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line6 : MonoBehaviour
{
    public GameObject Cylinder4Line;
    public GameObject Cylinder5;

    public GameObject Cylinder5Line;
    public GameObject Cylinder6;

    private LineRenderer lr5;
    public Transform[] Positions5;

    string guiText = "";
    string guiText5 = "";
    // Start is called before the first frame update
    void Start()
    {
        Cylinder4Line = GameObject.Find("Cylinder4Line");
        Cylinder5 = GameObject.Find("Cylinder5");

        Cylinder5Line = GameObject.Find("Cylinder5Line");
        Cylinder6 = GameObject.Find("Cylinder6");

        lr5 = gameObject.GetComponent<LineRenderer>();
        lr5.gameObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        lr5.enabled = false;
        lr5.useWorldSpace = true;
        lr5.startWidth = 0.0f;
        lr5.endWidth = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        lr5.startWidth = 0.0f;
        lr5.endWidth = 0.0f;


        float distance = Vector3.Distance(Cylinder4Line.transform.position, Cylinder5.transform.position);
        float walid = distance / 10;
        Debug.Log(distance);

        lr5.positionCount = Positions5.Length;
        lr5.SetPosition(0, Positions5[0].position);
        lr5.SetPosition(1, Positions5[1].position);


        float distance5 = Vector3.Distance(Cylinder5Line.transform.position, Cylinder6.transform.position);
        float walid5 = distance5 / 10;

        guiText5 = walid5.ToString();
        if (distance5 > 1 && distance5 < 10)
        {
            draw5();

        }
        else if (0.7 > distance5)
        {

            lr5.enabled = false;
        }

        Debug.Log(distance5);
    }


    void draw5()
    {

        lr5.startWidth = 0.05f;
        lr5.endWidth = 0.05f;

    }
}
