using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    // Use this for initialization
    void Start () {
	// Application.LoadLevel("Evig");
	
    }

    public  void Forever(){
        SceneManager.LoadScene("ForEver");
    }
   
	
}
