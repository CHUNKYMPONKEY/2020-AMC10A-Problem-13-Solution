using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour
{
    public float total;
    public float vertical;
    public float horizontal;
    public float percent;
    public float cool;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        total = vertical + horizontal;
        percent = (vertical * 100 / total);
        cool = horizontal * 100 / vertical;
    }
}
