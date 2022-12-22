using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score02 : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log(score);
        }
    }
}
