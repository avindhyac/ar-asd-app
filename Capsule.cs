using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public GameObject capsule;
    public GameObject capsuleBasket;
    public bool capsuleSelected;
    public bool capsuleBasketSelected;
    public bool regenCapsule;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Capsule")
                {
                    capsuleSelected = true;
                }
                else if (hit.transform.tag == "capsuleBasket")
                {
                    capsuleBasketSelected = true;
                }
            }

        }
    }

    public void capsuleTouch()
    {
        if (capsuleSelected == true && capsuleBasketSelected == true)
        {
            Destroy(capsule);
            regenCapsule = true;
            score.instance.AddScore();
        }
    }
}
