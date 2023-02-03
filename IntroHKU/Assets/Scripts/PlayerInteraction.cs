using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider != null)
            {
                GameObject hitGameObject = hit.collider.gameObject;

                if (hitGameObject.CompareTag("UpgradeBuilding"))
                {
                    hitGameObject.GetComponent<UpgradeScript>().Interact();
                }
            }
        }
    }
}
