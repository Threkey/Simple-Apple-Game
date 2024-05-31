using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int maxLife = 3, currentLife, score = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentLife <= 0)
        {
            SceneManager.LoadScene("TitleScene");
        }
        GameObject.Find("Score").GetComponent<TextMeshProUGUI>().text = "Score: " + score;
    }
}