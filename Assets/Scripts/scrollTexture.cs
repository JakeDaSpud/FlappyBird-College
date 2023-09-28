using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollTexture : MonoBehaviour
{
    private float initialPos;
    private float textureWidth;
    public float scrollSpeed; 

    // Start is called before the first frame update
    void Start()
    {
        initialPos = GetComponent<SpriteRenderer>().size.x;
        textureWidth = GetComponent<SpriteRenderer>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
