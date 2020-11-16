using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderer1 : MonoBehaviour
{

    public GameObject Cylinder;
    public GameObject Cylinder1;

    private LineRenderer lr;
    public Transform[] Positions;

    public float speed;



    void Start()
    {
        //lr.enabled = false;
        Cylinder = GameObject.Find("Cylinder");
        Cylinder1 = GameObject.Find("Cylinder1");

        lr = gameObject.GetComponent<LineRenderer>();
        //lr.gameObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);

        //lr.enabled = false;
        //lr.useWorldSpace = true;
        //lr.startWidth = 0.0f;
        //lr.endWidth = 0.0f;



    }

    // Update is called once per frame
    void Update()
    {

        // lr.startWidth = 0.0f;
        // lr.endWidth = 0.0f;
        /*
        lr.positionCount = Positions.Length;
        lr.SetPosition(0, Positions[0].position);
        lr.SetPosition(1, Positions[1].position);
        */

        lr.SetPosition(0, Positions[0].position);
        lr.SetPosition(1, Vector3.MoveTowards(transform.position, Positions[1].position, speed * Time.time));

        float distance = Vector3.Distance(Cylinder.transform.position, Cylinder1.transform.position);
        if (distance > 1 && distance < 5)
        {
            // draw();

        }
        else if (0.7 > distance)
        {
            lr.enabled = false;
        }
        Debug.Log(distance);

    }

    void draw()
    {
        lr.startWidth = 0.05f;
        lr.endWidth = 0.05f;
    }
}
