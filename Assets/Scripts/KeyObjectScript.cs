using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyObjectScript : MonoBehaviour
{
    [SerializeField]
    private Material plainMat;
    [SerializeField]
    private Material pulseMat;
    [SerializeField]
    private Material glowMat;
    [SerializeField]
    private float outlineThickness;
    [SerializeField]
    private Color outlineColor;
    [SerializeField]
    private float glowIntensity;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float maxDist;
    private bool isHovering;
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < maxDist)
        {
            if (!isHovering)
            {
                this.gameObject.GetComponent<SpriteRenderer>().material = pulseMat;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().material = glowMat;
            }
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().material = plainMat;
        }

    }

    void OnMouseEnter()
    {
        player.GetComponent<Inventory>().SelectKey(this.gameObject);
        isHovering = true;
    }

    void OnMouseExit()
    {
        player.GetComponent<Inventory>().UnSelectKey();
        isHovering = false;
    }
}
