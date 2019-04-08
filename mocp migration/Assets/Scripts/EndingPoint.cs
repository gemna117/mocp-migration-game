using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingPoint : MonoBehaviour
{
    public Texture2D zoomedInTexture;

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
