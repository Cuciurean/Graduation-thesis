using UnityEngine;
using System.Collections;

public class Rotate1 : MonoBehaviour {

    public GameObject Indicator1C;
    public GameObject Indicator2C;

  
    public GameObject CylinderC;
  

    float speedC = 50f;

    void Start()
    {
 
        CylinderC = GameObject.Find("CylinderC");

        Indicator1C = GameObject.Find("Indicator1C");
        Indicator2C = GameObject.Find("Indicator2C");
    
    }
    void Update()
    {

        // Piesa 1
        Indicator1C.transform.Rotate(0, 0, speedC * -Time.deltaTime);
        Indicator2C.transform.Rotate(0, 0, speedC * -Time.deltaTime);
        if (CylinderC.transform.rotation.eulerAngles.y >= 30 && CylinderC.transform.rotation.eulerAngles.y <= 180)
        {
            Indicator1C.SetActive(true);
            
        }
        else
        {
            Indicator1C.SetActive(false);
        }

        if (CylinderC.transform.rotation.eulerAngles.y >= 180  && CylinderC.transform.rotation.eulerAngles.y <= 330)
        {
            Indicator2C.SetActive(true);
        }
        else
        {
            Indicator2C.SetActive(false);
        }

       
    }
}
