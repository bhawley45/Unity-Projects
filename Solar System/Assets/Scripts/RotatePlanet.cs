using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float rotationSpeed; //In km/s (rounded to nearest hundreth)
     
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("RotatePlanet target not specified. Defaulting to parent GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate target
        transform.RotateAround(target.transform.position, target.transform.up, rotationSpeed * Time.deltaTime);
    }
}
