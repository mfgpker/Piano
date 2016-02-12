using UnityEngine;
using System.Collections;

public class Dead : MonoBehaviour {
    
    private int score;

    // Use this for initialization
    void Start () {
	GameObject DC = GameObject.Find("Dead");
	score = DC.GetComponent<DeadControl>().GetScore();
    }
	
    // Update is called once per frame
    void Update () {
	
    }
}
