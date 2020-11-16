using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line3 : MonoBehaviour
{

    public GameObject Cylinder1Line;
    public GameObject Cylinder2;

    public GameObject Cylinder2Line;
    public GameObject Cylinder3;
    
    private LineRenderer lr2;
    public Transform[] Positions2;

    // Start is called before the first frame update
    void Start()
    {
        Cylinder2Line = GameObject.Find("Cylinder2Line");
        Cylinder3 = GameObject.Find("Cylinder3");

        Cylinder2 = GameObject.Find("Cylinder2");
        Cylinder1Line = GameObject.Find("Cylinder1Line");

        lr2 = gameObject.GetComponent<LineRenderer>();
        lr2.gameObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        lr2.startWidth = 0.0f;
        lr2.endWidth = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        lr2.startWidth = 0.0f;
        lr2.endWidth = 0.0f;
 

        float distance = Vector3.Distance(Cylinder1Line.transform.position, Cylinder2.transform.position);

       
            lr2.positionCount = Positions2.Length;
            lr2.SetPosition(0, Positions2[0].position);
            lr2.SetPosition(1, Positions2[1].position);

            float distance2 = Vector3.Distance(Cylinder2Line.transform.position, Cylinder3.transform.position);
            float walid2 = distance2 / 10;

            if (distance2 > 1 && distance2 < 10)
            {
                draw2();

            }
            else if (0.7 > distance2)
            {

                lr2.enabled = false;
            }

            Debug.Log(distance2);
        
    }

    void draw2()
    {

        lr2.startWidth = 0.05f;
        lr2.endWidth = 0.05f;

    }
}
