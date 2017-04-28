using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehavior : MonoBehaviour
{

    public List<GameObject> boxes;
    public GameObject boxPrefab;
    public float offset;
    public int gridSize;

    // Use this for initialization
    void Start()
    {
        boxes = new List<GameObject>();
        Create();
    }


    [ContextMenu("Create")]
    void Create()
    {
        for (int x = 0 ; x < gridSize; x++)
        {
            for (int z = 0; z< gridSize; z++)
            {
                var pos = new Vector3(x * offset, 0, z * offset);
                var quat = new Quaternion(0 ,0 ,0, 0);
                GameObject box;
                box = Instantiate(boxPrefab, pos, quat) as GameObject;
                boxes.Add(box);
            }
        }
    }

    [ContextMenu("Destroy")]
    void Destroy()
    {
        foreach(GameObject box in boxes)
        {
            DestroyImmediate(box);
        }
        boxes.Clear();
    }

}
