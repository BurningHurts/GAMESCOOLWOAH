using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    private int Wisp = 0;
    private bool DoorStat = false;

    [SerializeField] private Text WispText;
    [SerializeField] private Text DoorText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        DoorStat = false;
        if (collision.gameObject.CompareTag("Wisp"))
        {
            Destroy(collision.gameObject);
            Wisp++;
            WispText.text = "Wisps: " + Wisp;

        }
    }
    void Update()
    {
        if ( Wisp >= 4f)
        {
            DoorStat |= true;

            DoorText.text = "Door is open!";


        }
   
    }
}
