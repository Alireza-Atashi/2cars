
using Unity.VisualScripting;
using UnityEngine;

public class entertriger : MonoBehaviour
{
    public SpM spm;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        spm.STE();
    }
}
