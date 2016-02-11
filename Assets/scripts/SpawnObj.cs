using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnObj : MonoBehaviour {

    public List<GameObject> spawnsPoints = new List<GameObject>();
    public GameObject prefab;
    public GameObject RowManager;

    // Use this for initialization
    void Start () {
	    foreach (GameObject obj in spawnsPoints) {
            GameObject row = (GameObject) Instantiate(prefab, obj.transform.position, Quaternion.identity);
            RowManager.SendMessage("AddRow", row);
        }
	}
	
    void Spawn() {
        GameObject spawnPot = spawnsPoints[4];
        GameObject row = (GameObject)Instantiate(prefab, spawnPot.transform.position, Quaternion.identity);
        RowManager.SendMessage("AddRow", row);
    }

}
