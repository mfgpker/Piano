using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RowMan : MonoBehaviour {
    public Material white, black;
    public List<GameObject> boxes = new List<GameObject>();

    // Use this for initialization
    void Start() {
       int r = Random.Range(0, 3);
       boxes[r].GetComponent<Renderer>().sharedMaterial = black;
       boxes[r].GetComponent<State>().isBlack = true;
       
    }
}
