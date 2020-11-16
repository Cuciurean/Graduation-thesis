using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line7 : MonoBehaviour
{
    public GameObject Cylinder5Line;
    public GameObject Cylinder6;

    public GameObject Cylinder6Line;
    public GameObject Cylinder7;

    private LineRenderer lr6;
    public Transform[] Positions6;

    string guiText = "";
    string guiText6 = "";
    // Start is called before the first frame update
    void Start()
    {
        Cylinder5Line = GameObject.Find("Cylinder5Line");
        Cylinder6 = GameObject.Find("Cylinder6");

        Cylinder6Line = GameObject.Find("Cylinder6Line");
        Cylinder7 = GameObject.Find("Cylinder7");

        lr6 = gameObject.GetComponent<LineRenderer>();
        lr6.gameObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        lr6.enabled = false;
        lr6.useWorldSpace = true;
        lr6.startWidth = 0.0f;
        lr6.endWidth = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        lr6.startWidth = 0.0f;
        lr6.endWidth = 0.0f;


        float distance = Vector3.Distance(Cylinder5Line.transform.position, Cylinder6.transform.position);
        float walid = distance / 10;
        Debug.Log(distance);

        lr6.positionCount = Positions6.Length;
        lr6.SetPosition(0, Positions6[0].position);
        lr6.SetPosition(1, Positions6[1].position);


        float distance6 = Vector3.Distance(Cylinder6Line.transform.position, Cylinder7.transform.position);
        float walid6 = distance6 / 10;

        guiText6 = walid6.ToString();
        if (distance6 > 1 && distance6 < 10)
        {
            draw6();

        }
        else if (0.7 > distance6)
        {

            lr6.enabled = false;
        }

        Debug.Log(distance6);
    }


    void draw6()
    {

        lr6.startWidth = 0.05f;
        lr6.endWidth = 0.05f;

    }
}
