using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addfuel : MonoBehaviour{

    public CarController carController;
    
    private void OnTriggerEnter2d(Collider2D collision)
    {
        carController.fuelconsumption = 1;
        Destroy(gameObject);
    }
}
