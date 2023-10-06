using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
