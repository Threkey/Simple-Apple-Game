using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public GameObject basket;
    public List<GameObject> basketList = new List<GameObject>();
    Vector3 basketPos, basketStackPos = Vector3.zero;
    int maxLife, currentLife;
    // Start is called before the first frame update
    void Start()
    {
        maxLife = GameObject.Find("@").GetComponent<GameManager>().maxLife;
        basketStackPos.y = 1.5f;
        basketPos.y = -(Camera.main.orthographicSize * 4f / 5f);
        for(int i = 0; i < maxLife; i++)
        {
            basketList.Add(Instantiate(basket, transform.position + i * basketStackPos, transform.rotation, transform));
        }
    }

    // Update is called once per frame
    void Update()
    {
        basketPos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        transform.position = basketPos;

        currentLife = GameObject.Find("@").GetComponent<GameManager>().currentLife;
        if (basketList.Count > currentLife)
            Destroy(basketList[currentLife]);
    }
}
