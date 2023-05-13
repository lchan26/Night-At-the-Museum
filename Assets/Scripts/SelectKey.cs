using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectKey : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (player.GetComponent<Inventory>().PickUpKey(new Vector2(transform.position.x, transform.position.y)))
        {
            Destroy(this.gameObject);
        }
    }
}
