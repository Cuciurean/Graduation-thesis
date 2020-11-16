using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line4 : MonoBehaviour
{
    public GameObject Cylinder2Line;
    public GameObject Cylinder3;

    public GameObject Cylinder3Line;
    public GameObject Cylinder4;

    private LineRenderer lr3;
    public Transform[] Positions3;

    // Start is called before the first frame update
    void Start()
    {
        Cylinder2Line = GameObject.Find("Cylinder2Line");
        Cylinder3 = GameObject.Find("Cylinder3");

        Cylinder3Line = GameObject.Find("Cylinder3Line");
        Cylinder4 = GameObject.Find("Cylinder4");

        lr3 = gameObject.GetComponent<LineRenderer>();
        lr3.gameObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        lr3.enabled = false;
        lr3.useWorldSpace = true;
        lr3.startWidth = 0.0f;
        lr3.endWidth = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        lr3.startWidth = 0.0f;
        lr3.endWidth = 0.0f;


        float distance = Vector3.Distance(Cylinder2Line.transform.position, Cylinder3.transform.position);
        Debug.Log(distance);

        lr3.positionCount = Positions3.Length;
        lr3.SetPosition(0, Positions3[0].position);
        lr3.SetPosition(1, Positions3[1].position);

  
        float distance3 = Vector3.Distance(Cylinder3Line.transform.position, Cylinder4.transform.position);

        if (distance3 > 1 && distance3 < 10)
        {
            draw3();

        }
        else if (0.7 > distance3)
        {

            lr3.enabled = false;
        }

        Debug.Log(distance3);
    }


    void draw3()
    {

        lr3.startWidth = 0.05f;
        lr3.endWidth = 0.05f;

    }
}
