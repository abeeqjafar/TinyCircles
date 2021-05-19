using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject other, gameManager, resetBtn;
    public float speed = 3f;
    bool flag;

    private void Start()
    {
        flag = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            flag = false;
            gameManager.SetActive(false);
            resetBtn.SetActive(true);
        }
    }


    void Update()
    {
        if (flag && gameManager.activeSelf)
        {
            transform.position = Vector3.MoveTowards(transform.position, other.transform.position, speed * Time.deltaTime);
        }
    }
}
