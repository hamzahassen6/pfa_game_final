using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererScript : MonoBehaviour
{
    public Transform rightcap;
    public Transform leftcap;
    public LineRenderer lr;
    void Start()
    {
        lr = GetComponent <LineRenderer>();
    }

    void Update()
    {
        lr.SetPosition(0, rightcap.position);
        lr.SetPosition(1, leftcap.position);
    }
}
