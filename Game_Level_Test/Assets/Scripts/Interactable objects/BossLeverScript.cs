using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLeverScript : MonoBehaviour
{
    public GameObject bossPlatform;
    public GameObject boss;

    bool canPull;

    // Update is called once per frame
    void Update()
    {
        if(canPull && Input.GetKeyDown(KeyCode.E))
        {
            bossPlatform.SetActive(false);
            boss.GetComponent<Animator>().SetTrigger("isDead");
            Destroy(boss.GetComponent<BomberGoblinScript>());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            canPull = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canPull = false;
    }
}