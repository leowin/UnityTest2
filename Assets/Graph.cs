using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Graph : MonoBehaviour
{
    public GameObject sampleObject;
     
    List<Node> nodes = new List<Node>();
    // Use this for initialization
    void Start()
    {
        for (var i = 0; i < 10; i++)
        {
            nodes.Add(new Node() { position = Random.insideUnitCircle, name = "Node " + i });
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnDrawGizmos()
    {
        nodes.ForEach((n) =>
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(n.position, 0.10f);
        });
    }
    public void AddObject()
    {
        Instantiate(sampleObject, Random.insideUnitCircle, Quaternion.identity);
    }
}

public class Node
{
    public Vector2 position;
    public string name;
    public List<Node> associations = new List<Node>();

}