using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public GameObject cubeToSpawn;
    public Transform spawnPoint;
    private List<Rigidbody> rBodyList;
    // Start is called before the first frame update
    void Start()
    {
        rBodyList = new List<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnCube()
    {
        rBodyList.Add(Instantiate(cubeToSpawn,spawnPoint.position,Quaternion.identity).GetComponent<Rigidbody>());
    }
    public void changeColor()
    {
        foreach (Rigidbody item in rBodyList)
        {
            item.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }
}
