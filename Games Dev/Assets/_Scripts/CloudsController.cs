<<<<<<< HEAD
﻿using System.Collections;
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
=======
﻿
>>>>>>> 74b8ca90e5d33d171939067fe16b4a0a6cc3b734
