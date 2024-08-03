using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    void Start()
    {
        Player palyer = new Player();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float ver = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
        transform.position += new Vector3(hor, ver, 0f);    }
}
