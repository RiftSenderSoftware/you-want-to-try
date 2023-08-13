using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSorter : MonoBehaviour
{
    public bool isStatic = false;
    public float offset = 0;
    private int sortingOrderBase = 0;
    private Renderer renderer;
    // Start is called before the first frame update
    void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        renderer.sortingOrder = (int)(sortingOrderBase - transform.position.y + offset);

        if(isStatic == true)
        {
            Destroy(this);
        }
    }
}
