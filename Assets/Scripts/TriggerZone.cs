using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public GameObject sphere;

    private Color originalColor;
    public Color newColor;

    private void Start()
    {
        originalColor = sphere.GetComponent<Renderer>().material.color;
      

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphere.GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("Entered");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphere.transform.localScale = Vector3.one * 0.01f;
            Debug.Log("Staying");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphere.transform.localScale = Vector3.one;
            sphere.GetComponent<Renderer>().material.color = originalColor;
            Debug.Log("Exited");
        }
    }
}
