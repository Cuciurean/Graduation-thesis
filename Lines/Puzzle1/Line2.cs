using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line2 : MonoBehaviour
{

    public GameObject Cylinder2;
    public GameObject Cylinder1Line;

    public GameObject Cylinder;
    public GameObject Cylinder1;

    private LineRenderer lr1;
    public Transform[] Positions1;

    // Start is called before the first frame update
    void Start()
    {
        Cylinder2 = GameObject.Find("Cylinder2");
        Cylinder1Line = GameObject.Find("Cylinder1Line");

        Cylinder = GameObject.Find("Cylinder");
        Cylinder1 = GameObject.Find("Cylinder1");

        lr1 = gameObject.GetComponent<LineRenderer>();
        lr1.gameObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        lr1.enabled = false;
        lr1.useWorldSpace = true;

        lr1.startWidth = 0.0f;
        lr1.endWidth = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        lr1.startWidth = 0.0f;
        lr1.endWidth = 0.0f;


        float distance = Vector3.Distance(Cylinder.transform.position, Cylinder1.transform.position);

            lr1.positionCount = Positions1.Length;
            lr1.SetPosition(0, Positions1[0].position);
            lr1.SetPosition(1, Positions1[1].position);

            float distance1 = Vector3.Distance(Cylinder1Line.transform.position, Cylinder2.transform.position);
      
            if (distance1 > 1 && distance1 < 10)
            {
                draw1();
            }
            else if (0.7 > distance1)
            {
                lr1.enabled = false;
            }

            Debug.Log(distance1);
    }
  
    void draw1()
    {
        lr1.startWidth = 0.05f;
        lr1.endWidth = 0.05f;
    }
}
