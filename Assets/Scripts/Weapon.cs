using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private StarterAssetsInputs _inputs;

    [SerializeField]
    private Transform notAimingPos;
    [SerializeField]
    private Transform aimingPos;

    // Start is called before the first frame update
    void Start()
    {
        _inputs = FindObjectOfType<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_inputs.aiming == true)
        {
            transform.position = aimingPos.position;
            transform.rotation = aimingPos.rotation;
            //set gun position to aiming position
        }
        else
        {
            transform.position = notAimingPos.position;
            transform.rotation = notAimingPos.rotation;
            //set it back to normal
        }
    }
}
