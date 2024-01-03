using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightScript : MonoBehaviour
{
    public float speed = 1f;
    public Transform sun;

    public void Update()
    {
        sun.transform.Rotate(Vector3.right * (Time.deltaTime * speed));
    }
    
}