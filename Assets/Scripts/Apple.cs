using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Apple : MonoBehaviour
{

    [SerializeField]
    float xlimit = 16.0f;
    [SerializeField]
    float ylimit = 8.5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-xlimit,xlimit),
        Random.Range(-ylimit,ylimit),0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.parent.GetComponent<MiniSnake>().AddTail();
            //Muda a posição na cena
            transform.position = new Vector3(Random.Range(-xlimit,xlimit),
            Random.Range(-ylimit,ylimit),0);
        } 
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
