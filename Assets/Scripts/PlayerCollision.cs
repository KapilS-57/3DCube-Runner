using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript _playerScript;
    public Score _score;
    public GameController _gameController;
    //private void OnCollisionEnter(Collision other)
    //{
    //    // Debug.Log("Player Collided.");
    //    // Debug.Log(other.gameObject.name);


    //    //if(other.gameObject.name == "RedCube")
    //    //{
    //    //    Destroy(other.gameObject);
    //    //}


    //    //if (other.gameObject.tag=="Collectables") 
    //    //{
    //    //   Destroy(other.gameObject);
    //    //}
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            _score.AddScore(1);
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            _gameController.GameOver();
            _playerScript.enabled = false;
        }
    } 
}
