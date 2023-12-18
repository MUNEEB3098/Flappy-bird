using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningObjects : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject[] powers;
    float min = 23.84304f,max= 240.3608f;
    void Start()
    {
        StartCoroutine(spawning());
    }

    // Update is called once per frame
    
    IEnumerator spawning() 
    {
        while (true) 
        {
            yield return new WaitForSeconds(Random.Range(4, 5));
            int index = Random.Range(0, powers.Length);
            if(powers[index]!=null)
            Instantiate(powers[index]);

            powers[index].transform.position = new Vector3(Random.Range(min, max), Random.Range(-3.26f, 2.46f), transform.position.y);
        }
    }
   
}
