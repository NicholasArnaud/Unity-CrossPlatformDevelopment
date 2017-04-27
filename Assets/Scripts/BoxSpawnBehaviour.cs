using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Spawn Boxes Behaviour
public class BoxSpawnBehaviour : MonoBehaviour
{
    public List<GameObject> boxes;
    public GameObject boxPrefab;
	
    void Start()
    {
        boxes = new List<GameObject>();
    }

    void Update()
    {
        GameObject box;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            box = Instantiate(boxPrefab) as GameObject;
            boxes.Add(box);
        }
    }

}