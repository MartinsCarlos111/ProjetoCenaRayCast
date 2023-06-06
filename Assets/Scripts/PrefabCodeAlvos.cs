using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCodeAlvos : MonoBehaviour
{
    public Vector3 position;
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        int qtd = Random.Range(1,15);
        for (int i = 0; i < qtd; i++)
        {
            float x = Random.Range(-20f, 30.0f);
            float y = 1.17f;
            float z = Random.Range(20f, 100.0f);
            position.Set(x,y,z);

            Instantiate(Cube, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
