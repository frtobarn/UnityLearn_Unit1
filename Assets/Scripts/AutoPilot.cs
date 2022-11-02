using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPilot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 15.0f);
    }
}
