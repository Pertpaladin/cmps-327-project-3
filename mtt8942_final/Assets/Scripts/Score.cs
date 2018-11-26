using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Script that keeps track of the player's health/score and 
//determines when he either loses or wins the game
public class Score : MonoBehaviour {

    private int health = 100;
    public Text countText;
    // Use this for initialization
    void Start()
    {
        countText.text = "Health: " + health.ToString();
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("good"))
        {
            health += 20;
            countText.text = "Health: " + health.ToString();
            if (health >= 200)
            {
                SceneManager.LoadScene(3);
            }
        }
        else if (other.gameObject.CompareTag("bad"))
        {
            health -= 50;
            countText.text = "Health: " + health.ToString();
            if(health <= 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }

}
