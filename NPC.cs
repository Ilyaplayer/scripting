using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // кол-во жизней
    public int healse = 4;
    // уровень игрока
    public int level = 1;
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        healse += level;
        print(healse);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
