using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Apple : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bottom")
            GameObject.Find("@").GetComponent<GameManager>().currentLife--;
        else if (collision.gameObject.tag == "Basket")
            GameObject.Find("@").GetComponent<GameManager>().score++;
        Destroy(gameObject);
        
    }
}
