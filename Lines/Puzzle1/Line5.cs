using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line5 : MonoBehaviour
{
    public GameObject Cylinder3Line;
    public GameObject Cylinder4;

    public GameObject Cylinder4Line;
    public GameObject Cylinder5;

    private LineRenderer lr4;
    public Transform[] Positions4;

    string guiText = "";
    string guiText4 = "";
    // Start is called before the first frame update
    void Start()
    {
        Cylinder4Line = GameObject.Find("Cylinder4Line");
        Cylinder5 = GameObject.Find("Cylinder5");

        Cylinder3Line = GameObject.Find("Cylinder3Line");
        Cylinder4 = GameObject.Find("Cylinder4");

        lr4 = gameObject.GetComponent<LineRenderer>();
        lr4.gameObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        lr4.enabled = false;
        lr4.useWorldSpace = true;
        lr4.startWidth = 0.0f;
        lr4.endWidth = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        lr4.startWidth = 0.0f;
        lr4.endWidth = 0.0f;


        float distance = Vector3.Distance(Cylinder3Line.transform.position, Cylinder4.transform.position);
        float walid = distance / 10;
        Debug.Log(distance);

        lr4.positionCount = Positions4.Length;
        lr4.SetPosition(0, Positions4[0].position);
        lr4.SetPosition(1, Positions4[1].position);


        float distance4 = Vector3.Distance(Cylinder4Line.transform.position, Cylinder5.transform.position);
        float walid4 = distance4 / 10;

        guiText4 = walid4.ToString();
        if (distance4 > 1 && distance4 < 10)
        {
            draw4();

        }
        else if (0.7 > distance4)
        {

            lr4.enabled = false;
        }

        Debug.Log(distance4);
    }


    void draw4()
    {

        lr4.startWidth = 0.05f;
        lr4.endWidth = 0.05f;

    }
}
