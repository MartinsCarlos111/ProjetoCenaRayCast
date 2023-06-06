using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCode : MonoBehaviour
{
    public Vector3 position;
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        //int qtd = Random.Range(1,10);
        int qtd = 600;
        for (int i = 0; i < qtd; i++){
            float x = i * 2.0f;
            position.Set(10.0f + x,2.1f, 0);

            Instantiate(Cube, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
