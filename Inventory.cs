using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Image[] images;
    public bool item1PickedUp;

    private void Start()
    {
        images = GetComponentsInChildren<Image>();
        foreach(Image image in images)
            {
            if(image.name=="item 1" && item1PickedUp)
            {
                image.overrideSprite(shipCone);
                image.overrideSprite(shipEngine);
                image.overrideSprite(shipFin);
               
            }
        }
    }
}
