using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Instantiate(objectThrown, transform.position, transform.rotation);
        }

    }
}
