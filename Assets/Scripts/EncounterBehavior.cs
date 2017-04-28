using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterBehavior : MonoBehaviour
{
    public Color originalColor;
    Material parentMaterial;
    public GameObject canvasGameObject;

    private void Start()
    {
        parentMaterial = GetComponentInParent<MeshRenderer>().materials[0];
        originalColor = parentMaterial.color;
        canvasGameObject = FindObjectOfType<Canvas>().gameObject;
        if (canvasGameObject == null)
            return;
        canvasGameObject.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            parentMaterial.color = Random.ColorHSV();

            canvasGameObject.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            parentMaterial.color = originalColor;

          //  canvasGameObject.SetActive(true);

        }
    }
}
