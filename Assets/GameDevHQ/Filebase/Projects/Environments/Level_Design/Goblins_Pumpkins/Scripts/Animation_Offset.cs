using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Offset : MonoBehaviour
{
    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        _anim.SetFloat("Offset", Random.Range(0.0f, 1.0f));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
