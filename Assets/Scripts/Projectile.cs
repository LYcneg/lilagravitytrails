using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public float speed;
    public bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        if(isActive)
            Invoke("DestroyThrowable", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
            transform.position += direction.offset * Time.deltaTime * speed;

    }
     private void DestroyThrowable()
    {
        Destroy(gameObject);
    }
}
