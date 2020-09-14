using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonEvenHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbButtonObject;
    public GameObject cube;
    public int buttonNumber;

    // Start is called before the first frame update
    void Start()
    {
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (buttonNumber == 2)
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (buttonNumber == 2)
        {
            cube.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (buttonNumber == 3)
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (buttonNumber == 4)
        {
            cube.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (buttonNumber == 5)
        {
            cube.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
