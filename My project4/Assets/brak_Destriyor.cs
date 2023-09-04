using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class brak_Destriyor : MonoBehaviour
{

    private void OnCollisionStay2D(Collision2D collision)
    {
       
        Destroy(this.gameObject);
   
    }
}
