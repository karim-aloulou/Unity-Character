using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    private float originalSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalSpeed = speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("water"))
        {
            speed /= 3f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("water"))
        {
            speed = originalSpeed;
        }
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag.Equals("coin"))
        {
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }
}

