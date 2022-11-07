using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionSlider : MonoBehaviour
{
    public GameObject Inventory;
    private bool inventoryActive;
    private bool pendingHideInventory;

    // Start is called before the first frame update
    void Start()
    {
        inventoryActive = false;
        pendingHideInventory = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!inventoryActive)
        {
            if (Input.GetKeyDown(KeyCode.E) && !Inventory.GetComponent<MoveSlider>().enabled)
            {
                Inventory.GetComponent<MoveSlider>().ResetVars();
                Inventory.GetComponent<MoveSlider>().enabled = true;
            }
            if (Inventory.GetComponent<MoveSlider>().IsFinishedLerp())
            {
                Inventory.GetComponent<MoveSlider>().enabled = false;
                inventoryActive = true;
            }
        }
    }

}
