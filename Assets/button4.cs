using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class button4 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbButtonObject;
    public GameObject cube;

    void Start()
    {
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.GetComponent<Renderer>().material.color = Color.yellow;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
