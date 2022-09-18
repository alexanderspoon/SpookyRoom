using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ellertson;

    // Start is called before the first frame update
    void Start()
    {
        Spawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawning() {
        float x = Random.Range(-2, 2);
        float z = Random.Range(-2, 2);

        Vector3 pos = new Vector3(x, 1.5f, z);

        Instantiate(ellertson, pos, Quaternion.identity);
    }
}
