using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    public GameObject cylinder;
    public GameObject cylinderBasket;
    public bool cylinderSelected;
    public bool cylinderBasketSelected;
    public bool regenCylinder;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Cylinder")
                {
                    cylinderSelected = true;
                }
                else if (hit.transform.tag == "cylinderBasket")
                {
                    cylinderBasketSelected = true;
                }
            }

        }
    }

    public void cylinderTouch()
    {
        if (cylinderSelected == true && cylinderBasketSelected == true)
        {
            Destroy(cylinder);
            regenCylinder = true;
            score.instance.AddScore();
        }
    }
}
