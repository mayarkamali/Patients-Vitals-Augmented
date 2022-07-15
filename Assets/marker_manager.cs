using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marker_manager : ScriptableObject
{

    public bool found_marker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void on_target_found()
    {
        found_marker = true;
    }
}
