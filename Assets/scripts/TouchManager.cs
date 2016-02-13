using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TouchManager : MonoBehaviour {

    public string PlatformDefines = "tom";



    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0)) {
            //Debug.Log(Input.mousePosition.ToString());
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)) {
                touch(hit.transform);
            }
            else {
                
            }
        }
    
    }

    void touch(Transform form) {
        GameObject hitObt = form.gameObject;
        GameObject.Find("RowManager").SendMessage("ClickedBlackKBox", hitObt);
      
    }
}
