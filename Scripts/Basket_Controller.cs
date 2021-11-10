using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket_Controller : MonoBehaviour {

    public GameObject cake_red;
    public GameObject cake_blue;
    public GameObject wine;
    public bool getItemAll = false;

    private int num = 0;
    const private int GET_ALL_ITEMS_NUM = 3;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	    if(num == GET_ALL_ITEMS_NUM)
        {
            getItemAll = true;
        }
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "cake_red")
        {
            other.gameObject.SetActive(false);
            cake_red.SetActive(true);
            num++;
        }
        else if (other.gameObject.tag == "cake_blue")
        {
            other.gameObject.SetActive(false);
            cake_blue.SetActive(true);
            num++;
        }
        else if (other.gameObject.tag == "Wine")
        {
            other.gameObject.SetActive(false);
            wine.SetActive(true);
            num++;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cake_red")
        {
            other.gameObject.SetActive(false);
            cake_red.SetActive(true);
            num++;
        }
        else if (other.gameObject.tag == "cake_blue")
        {
            other.gameObject.SetActive(false);
            cake_blue.SetActive(true);
            num++;
        }
        else if (other.gameObject.tag == "Wine")
        {
            other.gameObject.SetActive(false);
            wine.SetActive(true);
            num++;
        }
    }
}
