using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RowMan : MonoBehaviour {
    public Material white, black;
    public List<GameObject> boxes = new List<GameObject>();

    // Use this for initialization
    void Start() {
        int i = 1;
        foreach(GameObject obj in boxes) {
            int ran = Random.Range(0, 4) % 4;
            if(ran == 0 && i == 1) {
                obj.GetComponent<Renderer>().sharedMaterial = black;
                i = 0;
                obj.GetComponent<State>().isBlack = true;


            } else
                obj.GetComponent<Renderer>().sharedMaterial = white;
        }
        if(i == 1) {
            int r = Random.Range(0, 3);
            boxes[r].GetComponent<Renderer>().sharedMaterial = black;
            boxes[r].GetComponent<State>().isBlack = true;
        }
    }
}