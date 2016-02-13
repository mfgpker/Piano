using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeadControl : MonoBehaviour {
    
    private int scor;
    private string game;
    void Start(){
	    scor = 0;
        game = SceneManager.GetActiveScene().name;
        DontDestroyOnLoad(transform.gameObject);
    }
    

    void Die(int score){
	    scor = score;
        game = SceneManager.GetActiveScene().name;
        Debug.Log("You died! Score: " +  score);
        SceneManager.LoadScene("DeadScene");
    }

    public int GetScore(){
	    return scor;
    }
    public string GetName() {
        return game;
    }
}
