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
        if (other.gameObject.tag.Equals("coin"))
        {
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log('cc');
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("water"))
        {
            speed = originalSpeed;
        }
    }


    void Update()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }
}

