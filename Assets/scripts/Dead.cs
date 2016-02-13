using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
public class Dead : MonoBehaviour {
    
    private int score;
    private string game;
    public Text scoreTet;
    
    // Use this for initialization
    void Start () {
	    GameObject DC = GameObject.Find("Dead");
	    score = DC.GetComponent<DeadControl>().GetScore();
        game = DC.GetComponent<DeadControl>().GetName();
        scoreTet.text = score.ToString();
    }
	

    public void TryAgain() {
        SceneManager.LoadScene(game);
    }

    public void ToMenu() {
        SceneManager.LoadScene("Menu");
    }


    // Update is called once per frame
    void Update () {
	
    }
}
