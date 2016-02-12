using UnityEngine;
using System.Collections;

public class DeadControl : MonoBehaviour {
    
    private int scor;
    void Start(){
	scor = 0;
	DontDestroyOnLoad(transform.gameObject);
    }
    

    void Die(int score){
	scor = score;
	Debug.Log("You died! Score: " +  score);
	Application.LoadLevel("DeadScene");
    }

    public int GetScore(){
	return scor;
    }
}
