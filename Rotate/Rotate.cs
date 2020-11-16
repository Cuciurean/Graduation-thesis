using UnityEngine;
using System.Collections;

//Clasa folosita pentru verificarea pozitiei piesei

public class Rotate : MonoBehaviour {

    // Declararea obiectelor
    public GameObject Indicator1;
    public GameObject Indicator2;
    public GameObject Indicator3;
    public GameObject Indicator4;
    public GameObject Indicator5;
    public GameObject Indicator6;
    public GameObject Indicator7;
    public GameObject Indicator8;
    public GameObject Indicator9;
    public GameObject Indicator10;
    public GameObject Indicator11;
    public GameObject Indicator12;
    public GameObject Indicator13;
    public GameObject Indicator14;
    public GameObject Indicator15;
    public GameObject Indicator16;
    public GameObject Indicator17;
    public GameObject Indicator18;
  
    public GameObject Cylinder;
    public GameObject Cylinder1;
    public GameObject Cylinder1Line;
    public GameObject Cylinder2;
    public GameObject Cylinder3;
    public GameObject Cylinder4;
    public GameObject Cylinder5;
    public GameObject Cylinder6;
    public GameObject Cylinder7;
    public GameObject Cylinder8;

    float speed = 50f;

    void Start()
    {
        // Cautare obiecte potrivite
        Cylinder = GameObject.Find("Cylinder");
        Cylinder1 = GameObject.Find("Cylinder1");
        Cylinder1Line = GameObject.Find("Cylinder1Line");
        Cylinder2 = GameObject.Find("Cylinder2");
        Cylinder3 = GameObject.Find("Cylinder3");
        Cylinder4 = GameObject.Find("Cylinder4");
        Cylinder5 = GameObject.Find("Cylinder5");
        Cylinder6 = GameObject.Find("Cylinder6");
        Cylinder7 = GameObject.Find("Cylinder7");
        Cylinder8 = GameObject.Find("Cylinder8");
     

        Indicator1 = GameObject.Find("Indicator1");
        Indicator2 = GameObject.Find("Indicator2");
        Indicator3 = GameObject.Find("Indicator3");
        Indicator4 = GameObject.Find("Indicator4");
        Indicator5 = GameObject.Find("Indicator5");
        Indicator6 = GameObject.Find("Indicator6");
        Indicator7 = GameObject.Find("Indicator7");
        Indicator8 = GameObject.Find("Indicator8");
        Indicator9 = GameObject.Find("Indicator9");
        Indicator10 = GameObject.Find("Indicator10");
        Indicator11 = GameObject.Find("Indicator11");
        Indicator12 = GameObject.Find("Indicator12");
        Indicator13 = GameObject.Find("Indicator13");
        Indicator14 = GameObject.Find("Indicator14");
        Indicator15 = GameObject.Find("Indicator15");
        Indicator16 = GameObject.Find("Indicator16");
        Indicator17 = GameObject.Find("Indicator17");
        Indicator18 = GameObject.Find("Indicator18");
    }

    void Update()
    {
 
        // Piesa 1
        //Contine doua indicatoare, la care se aplica o viteza de rotatie
        Indicator1.transform.Rotate(0, 0, speed * -Time.deltaTime);
        Indicator2.transform.Rotate(0, 0, speed * -Time.deltaTime);

        //Se foloseste un obiect Cylinder care reprezinta pozitia piesei
        //Daca obiectul nu se afla in pozitia specificata se vor afisare indicatoarele
        //Pentru toate piesele este la fel
        if (Cylinder.transform.rotation.eulerAngles.y >= 30 && Cylinder.transform.rotation.eulerAngles.y <= 180)
        {
            Indicator1.SetActive(true);
            
        }
        else
        {
            Indicator1.SetActive(false);
        }

        if (Cylinder.transform.rotation.eulerAngles.y >= 180  && Cylinder.transform.rotation.eulerAngles.y <= 330)
        {
            Indicator2.SetActive(true);
        }
        else
        {
            Indicator2.SetActive(false);
        }

        //Piesa 2
        Indicator3.transform.Rotate(0, 0, speed * -Time.deltaTime);
        Indicator4.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (Cylinder1.transform.rotation.eulerAngles.y >= 30 && Cylinder1.transform.rotation.eulerAngles.y <= 180)
        {
            Indicator3.SetActive(true);

        }
        else
        {
            Indicator3.SetActive(false);
        }
        if (Cylinder1.transform.rotation.eulerAngles.y >= 180 && Cylinder1.transform.rotation.eulerAngles.y <= 330)
        {
            Indicator4.SetActive(true);
        }
        else
        {
            Indicator4.SetActive(false);
        }

        //Piesa 3
        Indicator5.transform.Rotate(0, 0, speed * -Time.deltaTime);
        Indicator6.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (Cylinder2.transform.rotation.eulerAngles.y >= 30 && Cylinder2.transform.rotation.eulerAngles.y <= 180)
        {
            Indicator5.SetActive(true);
        }
        else
        {
            Indicator5.SetActive(false);
        }
        if (Cylinder2.transform.rotation.eulerAngles.y >= 180 && Cylinder2.transform.rotation.eulerAngles.y <= 330)
        {
            Indicator6.SetActive(true);
        }
        else
        {
            Indicator6.SetActive(false);
        }

        //Piesa 4
        Indicator7.transform.Rotate(0, 0, speed * -Time.deltaTime);
        Indicator8.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (Cylinder3.transform.rotation.eulerAngles.y >= 30 && Cylinder3.transform.rotation.eulerAngles.y <= 180)
        {
            Indicator7.SetActive(true);
        }
        else
        {
            Indicator7.SetActive(false);
        }
        if (Cylinder3.transform.rotation.eulerAngles.y >= 180 && Cylinder3.transform.rotation.eulerAngles.y <= 330)
        {
            Indicator8.SetActive(true);
        }
        else
        {
            Indicator8.SetActive(false);
        }


        //Piesa 5
        Indicator9.transform.Rotate(0, 0, speed * -Time.deltaTime);
        Indicator10.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (Cylinder4.transform.rotation.eulerAngles.y >= 30 && Cylinder4.transform.rotation.eulerAngles.y <= 180)
        {
            Indicator9.SetActive(true);
        }
        else
        {
            Indicator9.SetActive(false);
        }
        if (Cylinder4.transform.rotation.eulerAngles.y >= 180 && Cylinder4.transform.rotation.eulerAngles.y <= 330)
        {
            Indicator10.SetActive(true);
        }
        else
        {
            Indicator10.SetActive(false);
        }


        //Piesa 6
        Indicator11.transform.Rotate(0, 0, speed * -Time.deltaTime);
        Indicator12.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (Cylinder5.transform.rotation.eulerAngles.y >= 30 && Cylinder5.transform.rotation.eulerAngles.y <= 180)
        {
            Indicator11.SetActive(true);
        }
        else
        {
            Indicator11.SetActive(false);
        }
        if (Cylinder5.transform.rotation.eulerAngles.y >= 180 && Cylinder5.transform.rotation.eulerAngles.y <= 330)
        {
            Indicator12.SetActive(true);
        }
        else
        {
            Indicator12.SetActive(false);
        }


        //Piesa 7
        Indicator13.transform.Rotate(0, 0, speed * -Time.deltaTime);
        Indicator14.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (Cylinder6.transform.rotation.eulerAngles.y >= 30 && Cylinder6.transform.rotation.eulerAngles.y <= 180)
        {
            Indicator13.SetActive(true);
        }
        else
        {
            Indicator13.SetActive(false);
        }
        if (Cylinder6.transform.rotation.eulerAngles.y >= 180 && Cylinder6.transform.rotation.eulerAngles.y <= 330)
        {
            Indicator14.SetActive(true);
        }
        else
        {
            Indicator14.SetActive(false);
        }


        //Piesa 8
        Indicator15.transform.Rotate(0, 0, speed * -Time.deltaTime);
        Indicator16.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (Cylinder7.transform.rotation.eulerAngles.y >= 30 && Cylinder7.transform.rotation.eulerAngles.y <= 180)
        {
            Indicator15.SetActive(true);
        }
        else
        {
            Indicator15.SetActive(false);
        }
        if (Cylinder7.transform.rotation.eulerAngles.y >= 180 && Cylinder7.transform.rotation.eulerAngles.y <= 330)
        {
            Indicator16.SetActive(true);
        }
        else
        {
            Indicator16.SetActive(false);
        }


        //Piesa 9
        Indicator17.transform.Rotate(0, 0, speed * -Time.deltaTime);
        Indicator18.transform.Rotate(0, 0, speed * -Time.deltaTime);
        if (Cylinder8.transform.rotation.eulerAngles.y >= 30 && Cylinder8.transform.rotation.eulerAngles.y <= 180)
        {
            Indicator17.SetActive(true);
        }
        else
        {
            Indicator17.SetActive(false);
        }
        if (Cylinder8.transform.rotation.eulerAngles.y >= 180 && Cylinder8.transform.rotation.eulerAngles.y <= 330)
        {
            Indicator18.SetActive(true);
        }
        else
        {
            Indicator18.SetActive(false);
        }

    }
}
