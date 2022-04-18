using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject sphere;
    public GameObject sphereBasket;
    public bool sphereSelected;
    public bool sphereBasketSelected;
    public bool regenSphere;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Sphere")
                {
                    sphereSelected = true;
                }
                else if (hit.transform.tag == "sphereBasket")
                {
                    sphereBasketSelected = true;
                }
            }

        }
    }

    public void sphereTouch()
    {
        if (sphereSelected == true && sphereBasketSelected == true)
        {
            Destroy(sphere);
            regenSphere = true;
            score.instance.AddScore();
        }
    }
}
