using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;

    public float range = 100f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
    }
    
    void Shoot()
    {
        GameObject fpsCam;
        
        fpsCam = GameObject.Find("Main Camera");
        
        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.gameObject.CompareTag("Enemy"))
            {
                Destroy(hit.transform.gameObject);
            }
        }
        
    }
}
