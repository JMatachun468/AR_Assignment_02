using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class button5 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbButtonObject;
    public GameObject cube;


    void Start()
    {
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.GetComponent<Renderer>().material.color = Color.magenta;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.GetComponent<Renderer>().material.color = Color.magenta;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
