using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RSp : MonoBehaviour
{

    public List<GameObject> roads;
    private float offset = 80f;
    void Start()
    {
        if (roads != null && roads.Count > 0)
        {
            roads = roads.OrderBy(r => r.transform.position.x).ToList();
        }
    }

    public void Moveroad()
    {
        GameObject moveroad = roads[0];
        roads.Remove(moveroad);
        float newX = roads[roads.Count - 1].transform.position.x + offset;
        moveroad.transform.position = new Vector3(newX,0,0);
        roads.Add(moveroad);
    }
}
