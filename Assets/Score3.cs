using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score3 : MonoBehaviour
{
    // Start is called before the first frame update
    private int score;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ball")
        {
            score = score + 3;
            Debug.Log(score);
        }
    }


}
