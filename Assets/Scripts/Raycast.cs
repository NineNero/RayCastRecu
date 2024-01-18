using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Apply a force to a rigidbody in the Scene at the point
    // where it is clicked.

    // The force with which the target is "poked" when hit.
    float pokeForce;

    //Cuando apuntas al objeto.
    public void Start()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log(Input.mousePosition);
        }
    }

    //Cuando clicas el objeto quitas puntos.
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForceAtPosition(ray.direction * pokeForce, hit.point);
                }
            }
        }
    }
}
