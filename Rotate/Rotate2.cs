using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{

    public GameObject IndicatorP1;
    public GameObject IndicatorP2;
    public GameObject IndicatorP3;
    public GameObject IndicatorP4;
    public GameObject IndicatorP5;
    public GameObject IndicatorP6;
    public GameObject IndicatorP7;
    public GameObject IndicatorP8;
    public GameObject IndicatorP9;
    public GameObject IndicatorP10;
    public GameObject IndicatorP11;
    public GameObject IndicatorP12;
    public GameObject IndicatorP13;
    public GameObject IndicatorP14;
    public GameObject IndicatorP15;
    public GameObject IndicatorP16;
    public GameObject IndicatorP17;
    public GameObject IndicatorP18;
    public GameObject IndicatorP19;
    public GameObject IndicatorP20;
    public GameObject IndicatorP21;
    public GameObject IndicatorP22;
    public GameObject IndicatorP23;
    public GameObject IndicatorP24;
    public GameObject IndicatorP25;
    public GameObject IndicatorP26;
    public GameObject IndicatorP27;
    public GameObject IndicatorP28;
    public GameObject IndicatorP29;
    public GameObject IndicatorP30;


    public GameObject CylinderP;
    public GameObject CylinderP1;
    public GameObject CylinderP2;
    public GameObject CylinderP3;
    public GameObject CylinderP4;
    public GameObject CylinderP5;
    public GameObject CylinderP6;
    public GameObject CylinderP7;
    public GameObject CylinderP8;
    public GameObject CylinderP9;
    public GameObject CylinderP10;
    public GameObject CylinderP11;
    public GameObject CylinderP12;
    public GameObject CylinderP13;
    public GameObject CylinderP14;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    float speed = 50f;

    // Update is called once per frame
    void Update()
    {
        // Piesa 1
        IndicatorP1.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP2.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP.transform.rotation.eulerAngles.y >= 30 && CylinderP.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP1.SetActive(true);
        }
        else
        {
            IndicatorP1.SetActive(false);
        }

        if (CylinderP.transform.rotation.eulerAngles.y >= 180 && CylinderP.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP2.SetActive(true);
        }
        else
        {
            IndicatorP2.SetActive(false);
        }

        // Piesa 2
        IndicatorP3.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP4.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP1.transform.rotation.eulerAngles.y >= 30 && CylinderP1.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP3.SetActive(true);
        }
        else
        {
            IndicatorP3.SetActive(false);
        }

        if (CylinderP1.transform.rotation.eulerAngles.y >= 180 && CylinderP1.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP4.SetActive(true);
        }
        else
        {
            IndicatorP4.SetActive(false);
        }

        // Piesa 3
        IndicatorP5.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP6.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP2.transform.rotation.eulerAngles.y >= 30 && CylinderP2.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP5.SetActive(true);
        }
        else
        {
            IndicatorP5.SetActive(false);
        }

        if (CylinderP2.transform.rotation.eulerAngles.y >= 180 && CylinderP2.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP6.SetActive(true);
        }
        else
        {
            IndicatorP6.SetActive(false);
        }

        // Piesa 4
        IndicatorP7.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP8.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP3.transform.rotation.eulerAngles.y >= 30 && CylinderP3.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP7.SetActive(true);
        }
        else
        {
            IndicatorP7.SetActive(false);
        }

        if (CylinderP3.transform.rotation.eulerAngles.y >= 180 && CylinderP3.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP8.SetActive(true);
        }
        else
        {
            IndicatorP8.SetActive(false);
        }

        // Piesa 5
        IndicatorP9.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP10.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP4.transform.rotation.eulerAngles.y >= 30 && CylinderP4.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP9.SetActive(true);
        }
        else
        {
            IndicatorP9.SetActive(false);
        }

        if (CylinderP4.transform.rotation.eulerAngles.y >= 180 && CylinderP4.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP10.SetActive(true);
        }
        else
        {
            IndicatorP10.SetActive(false);
        }

        // Piesa 6
        IndicatorP11.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP12.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP5.transform.rotation.eulerAngles.y >= 30 && CylinderP5.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP11.SetActive(true);
        }
        else
        {
            IndicatorP11.SetActive(false);
        }

        if (CylinderP5.transform.rotation.eulerAngles.y >= 180 && CylinderP5.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP12.SetActive(true);
        }
        else
        {
            IndicatorP12.SetActive(false);
        }


        // Piesa 7
        IndicatorP13.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP14.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP6.transform.rotation.eulerAngles.y >= 30 && CylinderP6.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP13.SetActive(true);
        }
        else
        {
            IndicatorP13.SetActive(false);
        }

        if (CylinderP6.transform.rotation.eulerAngles.y >= 180 && CylinderP6.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP14.SetActive(true);
        }
        else
        {
            IndicatorP14.SetActive(false);
        }


        // Piesa 8
        IndicatorP15.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP16.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP7.transform.rotation.eulerAngles.y >= 30 && CylinderP7.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP15.SetActive(true);
        }
        else
        {
            IndicatorP15.SetActive(false);
        }

        if (CylinderP7.transform.rotation.eulerAngles.y >= 180 && CylinderP7.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP16.SetActive(true);
        }
        else
        {
            IndicatorP16.SetActive(false);
        }


        // Piesa 9
        IndicatorP17.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP18.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP8.transform.rotation.eulerAngles.y >= 30 && CylinderP8.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP17.SetActive(true);
        }
        else
        {
            IndicatorP17.SetActive(false);
        }

        if (CylinderP8.transform.rotation.eulerAngles.y >= 180 && CylinderP8.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP18.SetActive(true);
        }
        else
        {
            IndicatorP18.SetActive(false);
        }


        // Piesa 10
        IndicatorP19.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP20.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP9.transform.rotation.eulerAngles.y >= 30 && CylinderP9.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP19.SetActive(true);
        }
        else
        {
            IndicatorP19.SetActive(false);
        }

        if (CylinderP9.transform.rotation.eulerAngles.y >= 180 && CylinderP9.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP20.SetActive(true);
        }
        else
        {
            IndicatorP20.SetActive(false);
        }


        // Piesa 11
        IndicatorP21.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP22.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP10.transform.rotation.eulerAngles.y >= 30 && CylinderP10.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP21.SetActive(true);
        }
        else
        {
            IndicatorP21.SetActive(false);
        }

        if (CylinderP10.transform.rotation.eulerAngles.y >= 180 && CylinderP10.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP22.SetActive(true);
        }
        else
        {
            IndicatorP22.SetActive(false);
        }

        // Piesa 12
        IndicatorP23.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP24.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP11.transform.rotation.eulerAngles.y >= 30 && CylinderP11.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP23.SetActive(true);
        }
        else
        {
            IndicatorP23.SetActive(false);
        }

        if (CylinderP11.transform.rotation.eulerAngles.y >= 180 && CylinderP11.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP24.SetActive(true);
        }
        else
        {
            IndicatorP24.SetActive(false);
        }

        // Piesa 13
        IndicatorP25.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP26.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP12.transform.rotation.eulerAngles.y >= 30 && CylinderP12.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP25.SetActive(true);
        }
        else
        {
            IndicatorP25.SetActive(false);
        }

        if (CylinderP12.transform.rotation.eulerAngles.y >= 180 && CylinderP12.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP26.SetActive(true);
        }
        else
        {
            IndicatorP26.SetActive(false);
        }

        // Piesa 14
        IndicatorP27.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP28.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP13.transform.rotation.eulerAngles.y >= 30 && CylinderP13.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP27.SetActive(true);
        }
        else
        {
            IndicatorP27.SetActive(false);
        }

        if (CylinderP13.transform.rotation.eulerAngles.y >= 180 && CylinderP13.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP28.SetActive(true);
        }
        else
        {
            IndicatorP28.SetActive(false);
        }

        // Piesa 15
        IndicatorP29.transform.Rotate(0, 0, speed * -Time.deltaTime);
        IndicatorP30.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (CylinderP14.transform.rotation.eulerAngles.y >= 30 && CylinderP14.transform.rotation.eulerAngles.y <= 180)
        {
            IndicatorP29.SetActive(true);
        }
        else
        {
            IndicatorP29.SetActive(false);
        }

        if (CylinderP14.transform.rotation.eulerAngles.y >= 180 && CylinderP14.transform.rotation.eulerAngles.y <= 330)
        {
            IndicatorP30.SetActive(true);
        }
        else
        {
            IndicatorP30.SetActive(false);
        }

    }
}
