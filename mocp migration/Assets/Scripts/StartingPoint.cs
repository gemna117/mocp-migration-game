using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingPoint : MonoBehaviour
{
    public Texture2D zoomedInTexture;
    private List<string> maplocations;
    List<GameObject> locations = new List<GameObject>();
    //ive learned im better at programming when i have example code to use as reference
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GameObject.Find("map").GetComponent<Renderer>().material.mainTexture = zoomedInTexture;
    }
}
