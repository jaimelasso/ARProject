using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class controlVirtualButtons : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vButtonAzul;
    private GameObject cuboAzul;
    private Material materialCuboAzul;

    private GameObject vButtonAmarillo;
    private GameObject cuboAmarillo;
    private Material materialCuboAmarillo;


    private GameObject vButtonRojo;
    private GameObject cuboRojo;
    private Material materialCuboRojo;

    public GameObject personaje;

    // Use this for initialization
    void Start () {

        cuboAzul = GameObject.Find("Cubo");
        materialCuboAzul = cuboAzul.GetComponent<Renderer>().material;

        //cuboAmarillo = GameObject.Find("cuboAmarillo");
        //materialCuboAmarillo = cuboAmarillo.GetComponent<Renderer>().material;

        //cuboRojo = GameObject.Find("cuboRojo");
        //materialCuboRojo = cuboRojo.GetComponent<Renderer>().material;

        vButtonAzul = GameObject.Find("botonAzul");
        vButtonAzul.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        //vButtonAmarillo = GameObject.Find("botonAmarillo");
        //vButtonAmarillo.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        //vButtonRojo = GameObject.Find("botonRojo");
        //vButtonRojo.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Botón Presionado");

        switch (vb.VirtualButtonName)
        {
            case "botonAmarillo":
                Debug.Log("Amarillo");
                //materialCubo.color = Color.yellow;
                break;

            case "botonAzul":
                Debug.Log("Azul");
                //materialCubo.color = Color.blue;
                break;

            case "botonRojo":
                Debug.Log("Rojo");
                //materialCubo.color = Color.red;
                break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Botón Liberado");
        //materialCubo.color = Color.white;
    }
}
