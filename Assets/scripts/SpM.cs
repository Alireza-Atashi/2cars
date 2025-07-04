using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpM : MonoBehaviour
{
    RSp RS;
    void Start()
    {
        RS = GetComponent<RSp>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void STE()
    {
        RS.Moveroad();
    }
}
