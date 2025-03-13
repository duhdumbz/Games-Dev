using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsController : MonoBehaviour
{
    [SerializeField]
    private Transform _cloud1;
    [SerializeField]
    private Transform[] _clouds = new Transform[6];
    void Start()
    {
        _clouds[0] = _cloud1;
    }

    void Update()
    {


    }
}