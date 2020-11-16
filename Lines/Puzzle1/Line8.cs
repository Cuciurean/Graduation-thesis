using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line8 : MonoBehaviour
{
    public GameObject Cylinder6Line;
    public GameObject Cylinder7;

    public GameObject Cylinder7Line;
    public GameObject Cylinder8;

    private LineRenderer lr7;
    public Transform[] Positions7;

    string guiText = "";
    string guiText7 = "";
    // Start is called before the first frame update
    void Start()
    {
        Cylinder6Line = GameObject.Find("Cylinder6Line");
        Cylinder7 = GameObject.Find("Cylinder7");

        Cylinder7Line = GameObject.Find("Cylinder7Line");
        Cylinder8 = GameObject.Find("Cylinder8");

        lr7 = gameObject.GetComponent<LineRenderer>();
        lr7.gameObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        lr7.enabled = false;
        lr7.useWorldSpace = true;
        lr7.startWidth = 0.0f;
        lr7.endWidth = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        lr7.startWidth = 0.0f;
        lr7.endWidth = 0.0f;


        float distance = Vector3.Distance(Cylinder6Line.transform.position, Cylinder7.transform.position);
        float walid = distance / 10;
        Debug.Log(distance);

        lr7.positionCount = Positions7.Length;
        lr7.SetPosition(0, Positions7[0].position);
        lr7.SetPosition(1, Positions7[1].position);


        float distance7 = Vector3.Distance(Cylinder7Line.transform.position, Cylinder8.transform.position);
        float walid7 = distance7 / 10;

        guiText7 = walid7.ToString();
        if (distance7 > 1 && distance7 < 10)
        {
            draw7();

        }
        else if (0.7 > distance7)
        {

            lr7.enabled = false;
        }

        Debug.Log(distance7);
    }


    void draw7()
    {

        lr7.startWidth = 0.05f;
        lr7.endWidth = 0.05f;

    }
}
