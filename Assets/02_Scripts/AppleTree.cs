using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    Vector3 treePos;
    float cameraHalfHeight, cameraHalfWidth, speed, maxSpeed, changeSpeedInterval, changeSpeedPercent;
    // Start is called before the first frame update
    void Start()
    {
        changeSpeedInterval = 0.3f;
        changeSpeedPercent = 0.5f;
        maxSpeed = 0.07f;

        cameraHalfHeight = Camera.main.orthographicSize;
        cameraHalfWidth = Camera.main.aspect * cameraHalfHeight;

        treePos.y = (2f / 3f) * cameraHalfHeight;           //사과나무 y축 설정
        
        transform.position = treePos;

        StartCoroutine(coChangeSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        ChangeTreePos();
    }

    void ChangeTreePos()
    {
        treePos.x += speed;
        if (treePos.x > cameraHalfWidth || treePos.x < -cameraHalfWidth)
            speed = -speed;
            transform.position = treePos;
    }

    IEnumerator coChangeSpeed()
    {
        while (true)
        {
            if(Random.Range(0f, 1f) < changeSpeedPercent)
            {
                speed = Random.Range(-maxSpeed, maxSpeed);
            }

            yield return new WaitForSeconds(changeSpeedInterval);
        }
    }
}
