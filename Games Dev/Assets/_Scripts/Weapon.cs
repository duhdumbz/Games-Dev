using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update void Start ()
    void Start()
    {

    }

        //Update is called once per frame
        void Update()
        {
            transform.RotateAround(Vector3.zero, Vector3.forward,200 * Time.deltaTime);
        }
    }

