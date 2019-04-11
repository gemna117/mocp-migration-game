using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingPoint : MonoBehaviour
{
    public Texture2D zoomedInTexture;
    private List<string> maplocations;
    //ive learned im better at programming when i have example code to use as reference
    void Start()
    {
        List<GameObject> locations = new List<GameObject>();

        locations.Add(new GameObject());
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
