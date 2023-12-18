using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    AudioSource collid;


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {

        collid.Play();
    }
}
