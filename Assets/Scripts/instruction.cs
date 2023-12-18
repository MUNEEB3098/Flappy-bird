using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instruction : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject instruct;
    AudioSource aud;
    private void Awake()
    {
        aud = GetComponent<AudioSource>();
        instruct.SetActive(false);
    }
    public void instructio() 
    {
        aud.Play(); 
        instruct.SetActive(true);
    }
    public void outstructio() 
    {
        aud.Play();
        instruct.SetActive(false);
    }
}
