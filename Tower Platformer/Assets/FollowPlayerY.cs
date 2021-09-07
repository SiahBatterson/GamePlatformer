using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tform;
        tform = this.transform.position;
        tform.x = this.transform.position.x;
        tform.y = GameObject.FindWithTag("Player").transform.position.y;
        this.transform.position = tform;
    }
}
