using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    //controleerd of je op de muis klikt
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }

    //schiet en controleerd of je een target raakt
    void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            
            TargetOrEnemy target = hit.transform.GetComponent<TargetOrEnemy>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
