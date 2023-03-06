using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public System.Random rnd;
    public int pos;
    public float resetEnemyTimer;
    // Start is called before the first frame update
    void Start()
    {
        resetEnemyTimer = 0;
        rnd = new System.Random();
        pos = rnd.Next(-1, 2) * 5;
        transform.position = new Vector3(pos, 0, 150);
    }

    // Update is called once per frame
    void Update()
    {
        pos = rnd.Next(-1, 2) * 5;
        resetEnemyTimer += Time.deltaTime;
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (resetEnemyTimer > 5)
        {
            transform.position = new Vector3(pos, 0, 150);
            resetEnemyTimer = 0;
        }
    }
}