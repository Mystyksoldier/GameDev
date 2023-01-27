using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockMouse : MonoBehaviour
{
    //haalt de muis van de player af zodat die in het menu kan bewegen
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

}
