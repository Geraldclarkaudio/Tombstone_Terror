using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombEntrance : MonoBehaviour
{
    [SerializeField]
    private bool _canEnter = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            _canEnter = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _canEnter = false;
        }
    }

    public bool CanEnterTomb()
    {
        return _canEnter;
    }
}
