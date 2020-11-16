using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    /* Declararea obictelor 3D*/
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;
    public GameObject sphere5;
    public GameObject sphere6;
    public GameObject sphere7;
    public GameObject sphere8;
    public GameObject sphere9;
    public GameObject sphere10;
    public GameObject sphere11;
    public GameObject sphere12;
    public GameObject sphere13;
    public GameObject sphere14;
    public GameObject sphere15;
    public GameObject sphere16;
    public GameObject sphere17;
    public GameObject sphere18;
    public GameObject sphere19;
    public GameObject sphere20;
    public GameObject sphere21;
    public GameObject sphere22;
    public GameObject sphere23;
    public GameObject sphere24;
 
    public GameObject Cube;
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;
    public GameObject Cube5;
    public GameObject Cube6;
    public GameObject Cube7;
    public GameObject Cube8;
    public GameObject Cube9;
    public GameObject Cube10;
    public GameObject Cube11;
    public GameObject Cube12;
    public GameObject Cube13;
    public GameObject Cube14;

    public GameObject logo;

    public string guiText;

    void Start()
    { 
        Cube = GameObject.Find("Cube");
        Cube1 = GameObject.Find("Cube1");
        Cube2 = GameObject.Find("Cube2");
        Cube3 = GameObject.Find("Cube3");
        Cube4 = GameObject.Find("Cube4");
        Cube5 = GameObject.Find("Cube5");
        Cube6 = GameObject.Find("Cube6");
        Cube7 = GameObject.Find("Cube7");
        Cube8 = GameObject.Find("Cube8");
        Cube9 = GameObject.Find("Cube9");
        Cube10 = GameObject.Find("Cube10");
        Cube11 = GameObject.Find("Cube11");
       
    }

    // Update is called once per frame
    void Update()
    {

        /* Calcuarea dinstantei intre 2 sfere 3d, 
         * pentru a determina daca 2 piese sunt conectate 
         * si daca sunt conectate corect*/
        logo.SetActive(false);

        /* Image1 */
        float distance = Vector3.Distance(sphere1.transform.position, sphere3.transform.position);

        /*Afisare dinstanta pe ecran*/
        float walid = distance / 10;
        guiText = walid.ToString();

        Cube.SetActive(false);
        if (distance > 0.5)
        {
            Cube.SetActive(false);
        }
        else if (0.3 > distance)
        {
            Cube.SetActive(true);
        }
        Debug.Log(distance);
     
        float distance11 = Vector3.Distance(sphere2.transform.position, sphere19.transform.position);
        Cube8.SetActive(false);
        if (distance11 > 0.5)
        {
            Cube8.SetActive(false);
        }
        else if (0.3 > distance11)
        {
            Cube8.SetActive(true);
        }
        Debug.Log(distance11);


        /* Image2 */
        float distance2 = Vector3.Distance(sphere4.transform.position, sphere6.transform.position);
        Cube1.SetActive(false);
        if (distance2 > 0.5)
        {
            Cube1.SetActive(false);
        }
        else if (0.3 > distance2)
        {
            Cube1.SetActive(true);
        }
        Debug.Log(distance2);

        float distance22 = Vector3.Distance(sphere5.transform.position, sphere23.transform.position);
        Cube9.SetActive(false);
        if (distance22 > 0.5)
        {
            Cube9.SetActive(false);
        }
        else if (0.3 > distance22)
        {
            Cube9.SetActive(true);
        }
        Debug.Log(distance22);


        /* Image3 */
        float distance3 = Vector3.Distance(sphere7.transform.position, sphere8.transform.position);
        Cube2.SetActive(false);
        if (distance3 > 0.5)
        {
            Cube2.SetActive(false);
        }
        else if (0.3 > distance3)
        {
            Cube2.SetActive(true);
        }
        Debug.Log(distance3);

        /* Image 4 */
        float distance4 = Vector3.Distance(sphere9.transform.position, sphere11.transform.position);
        Cube3.SetActive(false);
        if (distance4 > 0.5)
        {
            Cube3.SetActive(false);
        }
        else if (0.3 > distance4)
        {
            Cube3.SetActive(true);
        }
        Debug.Log(distance4);

        float distance44 = Vector3.Distance(sphere10.transform.position, sphere22.transform.position);
        Cube10.SetActive(false);
        if (distance44 > 0.5)
        {
            Cube10.SetActive(false);
        }
        else if (0.3 > distance44)
        {
            Cube10.SetActive(true);
        }
        Debug.Log(distance44);

        /* Image 5 */
        float distance5 = Vector3.Distance(sphere12.transform.position, sphere13.transform.position);
        Cube4.SetActive(false);
        if (distance5 > 0.5)
        {
            Cube4.SetActive(false);
        }
        else if (0.3 > distance5)
        {
            Cube4.SetActive(true);
        }
        Debug.Log(distance5);

        /* image 6 */
        float distance6 = Vector3.Distance(sphere14.transform.position, sphere16.transform.position);
        Cube5.SetActive(false);
        if (distance6 > 0.5)
        {
            Cube5.SetActive(false);
        }
        else if (0.3 > distance6)
        {
            Cube5.SetActive(true);
        }
        Debug.Log(distance6);

        float distance66 = Vector3.Distance(sphere15.transform.position, sphere24.transform.position);
        Cube11.SetActive(false);
        if (distance66 > 0.6)
        {
            Cube11.SetActive(false);
        }
        else if (0.4 > distance66)
        {
            Cube11.SetActive(true);
        }
        Debug.Log(distance66);

        /* Image7 */
        float distance7 = Vector3.Distance(sphere17.transform.position, sphere18.transform.position);
        Cube6.SetActive(false);
        if (distance7 > 0.5)
        {
            Cube6.SetActive(false);
        }
        else if (0.3 > distance7)
        {
            Cube6.SetActive(true);
        }
        Debug.Log(distance7);

        /* imgae 8 */
        float distance8 = Vector3.Distance(sphere20.transform.position, sphere21.transform.position);
        Cube7.SetActive(false);
        if (distance8 > 0.5)
        {

            Cube7.SetActive(false);
        }
        else if (0.3 > distance8)
        {
            Cube7.SetActive(true);
        }
        Debug.Log(distance8);


        //Atunci cand se adauga ultima piesa se verifica conexiunile
        //se afiseaza mesajul de finalizare
       if(0.4 > distance66 && 0.3 > distance22)
        {
            logo.SetActive(true);
            Cube.SetActive(false);
            Cube1.SetActive(false);
            Cube2.SetActive(false);
            Cube3.SetActive(false);
            Cube4.SetActive(false);
            Cube5.SetActive(false);
            Cube6.SetActive(false);
            Cube7.SetActive(false);
            Cube8.SetActive(false);
            Cube9.SetActive(false);
            Cube10.SetActive(false);
            Cube11.SetActive(false);
            Cube12.SetActive(false);
            Cube13.SetActive(false);
            Cube14.SetActive(false);
     
        }
       else if(0.4 > distance66 && 0.3 > distance8)
        {
            logo.SetActive(true);
            Cube.SetActive(false);
            Cube1.SetActive(false);
            Cube2.SetActive(false);
            Cube3.SetActive(false);
            Cube4.SetActive(false);
            Cube5.SetActive(false);
            Cube6.SetActive(false);
            Cube7.SetActive(false);
            Cube8.SetActive(false);
            Cube9.SetActive(false);
            Cube10.SetActive(false);
            Cube11.SetActive(false);
            Cube12.SetActive(false);
            Cube13.SetActive(false);
            Cube14.SetActive(false);
        }
       else if(0.4 > distance66 && 0.3 > distance44)
        {
            logo.SetActive(true);
            Cube.SetActive(false);
            Cube1.SetActive(false);
            Cube2.SetActive(false);
            Cube3.SetActive(false);
            Cube4.SetActive(false);
            Cube5.SetActive(false);
            Cube6.SetActive(false);
            Cube7.SetActive(false);
            Cube8.SetActive(false);
            Cube9.SetActive(false);
            Cube10.SetActive(false);
            Cube11.SetActive(false);
            Cube12.SetActive(false);
            Cube13.SetActive(false);
            Cube14.SetActive(false);
        }
        else if (0.3 > distance22 && 0.3 > distance8)
        {
            logo.SetActive(true);
            Cube.SetActive(false);
            Cube1.SetActive(false);
            Cube2.SetActive(false);
            Cube3.SetActive(false);
            Cube4.SetActive(false);
            Cube5.SetActive(false);
            Cube6.SetActive(false);
            Cube7.SetActive(false);
            Cube8.SetActive(false);
            Cube9.SetActive(false);
            Cube10.SetActive(false);
            Cube11.SetActive(false);
            Cube12.SetActive(false);
            Cube13.SetActive(false);
            Cube14.SetActive(false);
        }
        else if (0.3 > distance22 && 0.3 > distance44)
        {
            logo.SetActive(true);
            Cube.SetActive(false);
            Cube1.SetActive(false);
            Cube2.SetActive(false);
            Cube3.SetActive(false);
            Cube4.SetActive(false);
            Cube5.SetActive(false);
            Cube6.SetActive(false);
            Cube7.SetActive(false);
            Cube8.SetActive(false);
            Cube9.SetActive(false);
            Cube10.SetActive(false);
            Cube11.SetActive(false);
            Cube12.SetActive(false);
            Cube13.SetActive(false);
            Cube14.SetActive(false);
        }
        else if (0.3 > distance44 && 0.3 > distance8)
        {
            logo.SetActive(true);
            Cube.SetActive(false);
            Cube1.SetActive(false);
            Cube2.SetActive(false);
            Cube3.SetActive(false);
            Cube4.SetActive(false);
            Cube5.SetActive(false);
            Cube6.SetActive(false);
            Cube7.SetActive(false);
            Cube8.SetActive(false);
            Cube9.SetActive(false);
            Cube10.SetActive(false);
            Cube11.SetActive(false);
            Cube12.SetActive(false);
            Cube13.SetActive(false);
            Cube14.SetActive(false);
        }
        
       


    }
    /* Functie afisare dinstanta pe eran*/
    /*void OnGUI()
    {
        GUIStyle localStyle = new GUIStyle();
        localStyle.normal.textColor = Color.red;
        localStyle.fontSize = 30;
        GUI.Label(new Rect(20, 50, Screen.width - 20, 30), guiText+" CM ", localStyle);
    }*/
}
