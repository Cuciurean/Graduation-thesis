using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Btn : MonoBehaviour
{

    public GameObject buttonPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableButtons()
    {
        buttonPanel.SetActive(true);
    }
}
