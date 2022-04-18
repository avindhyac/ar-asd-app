using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameObject cube;
    public GameObject cubeBasket;
    public bool cubeSelected;
    public bool cubeBasketSelected;
    public bool regenCube;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Cube")
                {
                    cubeSelected = true;
                }
                else if (hit.transform.tag == "cubeBasket")
                {
                    cubeBasketSelected = true;
                }
            }

        }
    }

    public void cubeTouch()
    {
        if (cubeSelected == true && cubeBasketSelected == true)
        {
            Destroy(cube);
            regenCube = true;
            score.instance.AddScore();
        }
    }
}