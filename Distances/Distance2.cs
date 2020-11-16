using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance2 : MonoBehaviour
{
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
    public GameObject sphere25;
    public GameObject sphere26;
    public GameObject sphere27;
    public GameObject sphere28;
    public GameObject sphere29;
    public GameObject sphere30;
    public GameObject sphere31;
    public GameObject sphere32;
    public GameObject sphere33;
    public GameObject sphere34;
    public GameObject sphere35;
    public GameObject sphere36;
    public GameObject sphere37;
    public GameObject sphere38;
    public GameObject sphere39;
    public GameObject sphere40;
    public GameObject sphere41;
    public GameObject sphere42;
    public GameObject sphere43;

    public GameObject ok1;
    public GameObject ok2;
    public GameObject ok3;
    public GameObject ok4;
    public GameObject ok5;
    public GameObject ok6;
    public GameObject ok7;
    public GameObject ok8;
    public GameObject ok9;
    public GameObject ok10;
    public GameObject ok11;
    public GameObject ok12;
    public GameObject ok13;
    public GameObject ok14;
    public GameObject ok15;
    public GameObject ok16;
    public GameObject ok17;
    public GameObject ok18;
    public GameObject ok19;
    public GameObject ok20;
    public GameObject ok21;
    public GameObject ok22;


    string guiText = "";
 

    // Update is called once per frame
    void Update()
    {
        /* Calcuarea dinstantei intre 2 sfere 3d, 
         * pentru a determina daca 2 piese sunt conectate 
         * si daca sunt conectate corect*/

        float distance = Vector3.Distance(sphere1.transform.position, sphere3.transform.position);
        ok1.SetActive(false);
        if (distance > 0.5)
        {
            ok1.SetActive(false);
        }
        else if (0.3 > distance)
        {
            ok1.SetActive(true);
        }
        Debug.Log(distance);


        float distance1 = Vector3.Distance(sphere4.transform.position, sphere6.transform.position);
        ok2.SetActive(false);
        if (distance1 > 0.5)
        {
            ok2.SetActive(false);
        }
        else if (0.3 > distance1)
        {
            ok2.SetActive(true);
        }
        Debug.Log(distance1);


        float distance2 = Vector3.Distance(sphere7.transform.position, sphere9.transform.position);
        ok3.SetActive(false);
        if (distance2 > 0.5)
        {
            ok3.SetActive(false);
        }
        else if (0.3 > distance2)
        {
            ok3.SetActive(true);
        }
        Debug.Log(distance2);


        float distance3 = Vector3.Distance(sphere10.transform.position, sphere12.transform.position);
        ok4.SetActive(false);
        if (distance3 > 0.5)
        {
            ok4.SetActive(false);
        }
        else if (0.3 > distance3)
        {
            ok4.SetActive(true);
        }
        Debug.Log(distance3);


        float distance4 = Vector3.Distance(sphere13.transform.position, sphere14.transform.position);
        ok5.SetActive(false);
        if (distance4 > 0.5)
        {
            ok5.SetActive(false);
        }
        else if (0.3 > distance4)
        {
            ok5.SetActive(true);
        }
        Debug.Log(distance4);


        float distance5 = Vector3.Distance(sphere15.transform.position, sphere17.transform.position);
        ok6.SetActive(false);
        if (distance5 > 0.6)
        {
            ok6.SetActive(false);
        }
        else if (0.4 > distance5)
        {
            ok6.SetActive(true);
        }
        Debug.Log(distance5);


        float distance6 = Vector3.Distance(sphere18.transform.position, sphere19.transform.position);
        ok7.SetActive(false);
        if (distance6 > 0.6)
        {
            ok7.SetActive(false);
        }
        else if (0.4 > distance6)
        {
            ok7.SetActive(true);
        }
        Debug.Log(distance6);


        float distance7= Vector3.Distance(sphere20.transform.position, sphere21.transform.position);
        ok8.SetActive(false);
        if (distance7 > 0.6)
        {
            ok8.SetActive(false);
        }
        else if (0.4 > distance7)
        {
            ok8.SetActive(true);
        }
        Debug.Log(distance7);


        float distance8 = Vector3.Distance(sphere22.transform.position, sphere24.transform.position);
        ok9.SetActive(false);
        if (distance8 > 0.6)
        {
            ok9.SetActive(false);
        }
        else if (0.4 > distance8)
        {
            ok9.SetActive(true);
        }
        Debug.Log(distance8);


        float distance9 = Vector3.Distance(sphere25.transform.position, sphere27.transform.position);
        ok10.SetActive(false);
        if (distance9 > 0.5)
        {
            ok10.SetActive(false);
        }
        else if (0.3> distance9)
        {
            ok10.SetActive(true);
        }
        Debug.Log(distance9);


        float distance10 = Vector3.Distance(sphere28.transform.position, sphere29.transform.position);
        ok11.SetActive(false);
        if (distance10 > 0.5)
        {
            ok11.SetActive(false);
        }
        else if (0.3 > distance10)
        {
            ok11.SetActive(true);
        }
        Debug.Log(distance10);


        float distance11 = Vector3.Distance(sphere2.transform.position, sphere30.transform.position);
        ok12.SetActive(false);
        if (distance11> 0.5)
        {
            ok12.SetActive(false);
        }
        else if (0.3 > distance11)
        {
            ok12.SetActive(true);
        }
        Debug.Log(distance11);


        float distance12 = Vector3.Distance(sphere32.transform.position, sphere31.transform.position);
        ok19.SetActive(false);
        if (distance12 > 0.6)
        {
            ok19.SetActive(false);
        }
        else if (0.4 > distance12)
        {
            ok19.SetActive(true);
        }
        Debug.Log(distance12);


        float distance13 = Vector3.Distance(sphere34.transform.position, sphere5.transform.position);
        ok13.SetActive(false);
        if (distance13> 0.5)
        {
            ok13.SetActive(false);
        }
        else if (0.3 > distance13)
        {
            ok13.SetActive(true);
        }
        Debug.Log(distance13);


        float distance14 = Vector3.Distance(sphere35.transform.position, sphere26.transform.position);
        ok18.SetActive(false);
        if (distance14 > 0.5)
        {
            ok18.SetActive(false);
        }
        else if (0.3 > distance14)
        {
            ok18.SetActive(true);
        }
        Debug.Log(distance14);


        float distance15 = Vector3.Distance(sphere33.transform.position, sphere36.transform.position);
        ok20.SetActive(false);
        if (distance15 > 0.5)
        {
            ok20.SetActive(false);
        }
        else if (0.3 > distance15)
        {
            ok20.SetActive(true);
        }
        Debug.Log(distance15);


        float distance16 = Vector3.Distance(sphere38.transform.position, sphere8.transform.position);
        ok14.SetActive(false);
        if (distance16 > 0.5)
        {
            ok14.SetActive(false);
        }
        else if (0.3 > distance16)
        {
            ok14.SetActive(true);
        }
        Debug.Log(distance16);


        float distance17 = Vector3.Distance(sphere39.transform.position, sphere23.transform.position);
        ok17.SetActive(false);
        if (distance17 > 0.5)
        {
            ok17.SetActive(false);
        }
        else if (0.3 > distance17)
        {
            ok17.SetActive(true);
        }
        Debug.Log(distance17);


        float distance18 = Vector3.Distance(sphere37.transform.position, sphere40.transform.position);
        ok21.SetActive(false);
        if (distance18 > 0.6)
        {
            ok21.SetActive(false);
        }
        else if (0.4 > distance18)
        {
            ok21.SetActive(true);
        }
        Debug.Log(distance18);


        float distance19 = Vector3.Distance(sphere42.transform.position, sphere11.transform.position);
        ok15.SetActive(false);
        if (distance19 > 0.6)
        {
            ok15.SetActive(false);
        }
        else if (0.4 > distance19)
        {
            ok15.SetActive(true);
        }
        Debug.Log(distance19);


        float distance20 = Vector3.Distance(sphere43.transform.position, sphere21.transform.position);
        ok16.SetActive(false);
        if (distance20 > 0.6)
        {
            ok16.SetActive(false);
        }
        else if (0.4 > distance20)
        {
            ok16.SetActive(true);
        }
        Debug.Log(distance20);


        float distance21 = Vector3.Distance(sphere41.transform.position, sphere16.transform.position);
        ok22.SetActive(false);
        if (distance21 > 0.6)
        {
            ok22.SetActive(false);
        }
        else if (0.4 > distance21)
        {
            ok22.SetActive(true);
        }
        Debug.Log(distance21);
    }
}
