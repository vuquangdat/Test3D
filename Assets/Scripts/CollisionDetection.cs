using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter" + other.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerEnter" + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerEnter" + other.name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter" +collision.gameObject.name);

    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay" + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionEnter" + collision.gameObject.name);
    }
}
