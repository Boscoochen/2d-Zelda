using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitching : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;

    void Start()
    {
        player1.gameObject.SetActive(true);
        player2.gameObject.SetActive(false);
        player3.gameObject.SetActive(false);
    }


    void Update()
    {
        if (Input.GetButtonDown("1Key"))
        {
            player1.gameObject.SetActive(true);
            player2.gameObject.SetActive(false);
            player3.gameObject.SetActive(false);
            

            Debug.Log("key1");
        }
        else if (Input.GetButtonDown("2Key"))
        {
            player1.gameObject.SetActive(false);
            player2.gameObject.SetActive(true);
            player3.gameObject.SetActive(false);
            Debug.Log("key2");
        }
        else if (Input.GetButtonDown("3Key"))
        {
            player1.gameObject.SetActive(false);
            player2.gameObject.SetActive(false);
            player3.gameObject.SetActive(true);
            Debug.Log("key3");
        }
    }
}
