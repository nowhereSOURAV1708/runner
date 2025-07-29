using System.Collections.Generic;
using System.Collections;
using UnityEngine;


public class Obstacle : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
