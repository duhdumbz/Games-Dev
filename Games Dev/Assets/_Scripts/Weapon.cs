using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Weapon : MonoBehaviour
{   
    [SerializeField]
    private int rotationSpeed = 200;
    [SerializeField]
    private Vector3 rotationPoint = Vector3.zero;

    // Start is called before the first frame update void Start ()
    void Start()
    {

    }

        //Update is called once per frame
        void Update()
        {
            float rotationAmount = CalculateRotationAmount(Time.deltaTime);
            transform.RotateAround(rotationPoint, Vector3.forward, rotationAmount);
        return;
        }

        private float CalculateRotationAmount(float delta)
    {
        return rotationSpeed * delta;
    }
}

