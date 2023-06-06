using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public int contaPonto;
    public int contador;

    // Define a distância máxima do raio
    public float maxDistance = 10f;

    // Define a força a ser aplicada sobre os objetos atingidos pelo raio
    public float forceAmount = 150f;
    public Vector3 position;
    public GameObject Cube;
    void Update()
    {
        contaPonto = 0;
        // Verifica se o botão esquerdo do mouse foi pressionado
        if (Input.GetMouseButtonDown(0))
        {
            // Cria um raio a partir da posição da câmera na direção do mouse
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Cria um objeto que armazenará informações sobre a colisão do raio
            RaycastHit hit;


            // Verifica se o raio atinge algum objeto na cena
            if (Physics.Raycast(ray, out hit, maxDistance))
            {
                //contador de pontos!
                while (contaPonto != 1)
                {
                    if(Physics.Raycast(ray, out hit, maxDistance))
                    {
                        contador++;
                    }
                    Debug.Log("Pontos: " + contador);
                    contaPonto++;

                    float x = Random.Range(-20f, 30.0f);
                    float y = 1.17f;
                    float z = Random.Range(20f, 100.0f);
                    position.Set(x, y, z);

                    Instantiate(Cube, position, Quaternion.identity);
                }
                

                // Imprime o nome do objeto que foi atingido pelo raio
                //Debug.Log("Raio atingiu o objeto: " + hit.collider.gameObject.name);

                // Aplica uma força sobre o objeto atingido
                Rigidbody rb = hit.collider.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddForce(ray.direction * forceAmount, ForceMode.Impulse);
                }
            }
        }
       
    }
}