using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starta : MonoBehaviour
{
    // Start is called before the first frame update
    public void Starting()
    {
        
        Destroy(GameObject.FindWithTag("Start"));

    }
    private void Awake()
    {
        StartCoroutine(awa());
    }
    IEnumerator awa() 
    {
        yield return new WaitForSeconds(1);
        Starting();
    }
    // Update is called once per frame

}
