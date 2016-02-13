using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RowManager : MonoBehaviour {

    public List<GameObject> Rows = new List<GameObject>();
    public GameObject rowFab;
    public GameObject SpawnsPoint;
    public Text ScoreText;
    private int score;

    void ClickedBlackKBox(GameObject obj) {
	    GameObject GM = GameObject.Find("Dead");
	    if (!obj.GetComponent<State>().isBlack){
	        GM.SendMessage("Die", score);
	    } else {
	        GameObject parent = obj.transform.parent.gameObject;
	        if(parent == Rows[0]) {
		    Destroy(parent);
		    Rows.RemoveAt(0);
		    foreach(GameObject row in Rows) {
		        Vector3 pos = row.transform.position;
		        pos.y -= 1.745431F;
		        row.transform.position = pos;
		    }
		    score += 1;
            ScoreText.text = score.ToString();
		    SpawnsPoint.SendMessage("Spawn");
	        } else {
		    GM.SendMessage("Die", score);
	        }
	    }
    }
   
    void AddRow(GameObject row) {
        Rows.Add(row);
    }

    void Start(){
	score = 0;
    }
}
