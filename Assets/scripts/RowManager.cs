using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RowManager : MonoBehaviour {

    public List<GameObject> Rows = new List<GameObject>();
    public GameObject rowFab;
    public GameObject SpawnsPoint;


    void ClickedBlackKBox(GameObject obj) {
        GameObject parent = obj.transform.parent.gameObject;
        if(parent == Rows[0]) {
            Destroy(parent);
            Rows.RemoveAt(0);
            foreach(GameObject row in Rows) {
                Vector3 pos = row.transform.position;
                pos.y -= 1.745431F;
                row.transform.position = pos;
            }
            SpawnsPoint.SendMessage("Spawn");
        } else {
            Debug.Log("Dead");
        }
    }
   
    void AddRow(GameObject row) {
        Rows.Add(row);
    }
}
