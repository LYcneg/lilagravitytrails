using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public Text collectibleCounter;
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (throwableCounter > 0)
            {
                offset = transform.localScale.x * new Vector3(5, 0, 0);
                Vector3 throwablePosition = transform.position + offset;
                GameObject p = Instantiate(objectThrown, throwablePosition, transform.rotation);
                p.GetComponent<Projectile>().isActive = true;
                throwableCounter --;
                collectibleCounter.text = throwableCounter.ToString();
            }
        }
        
    }
   void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Collectible")
        {
            throwableCounter++;
            collectibleCounter.text = throwableCounter.ToString();
            Destroy(col.gameObject);
        }
    }
}
