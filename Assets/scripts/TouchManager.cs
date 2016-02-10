using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TouchManager : MonoBehaviour {

    public string PlatformDefines = "tom";
    public Text text;
    // Use this for initialization
    void Start () {

#if UNITY_IPHONE
    PlatformDefines = "Phone";
#endif

#if UNITY_ANDROID
    PlatformDefines = "Phone";
#endif

#if UNITY_EDITOR
        PlatformDefines = "Unity Editor";
#endif


#if UNITY_STANDALONE_OSX
    PlatformDefines = "Desktop";
#endif

#if UNITY_STANDALONE_WIN
    PlatformDefines = "Desktop";
#endif
        //text.text = PlatformDefines;
    }


    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0)) {
            Debug.Log(Input.mousePosition.ToString());
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)) {
                touch(hit.transform);
            }
            else {
                
            }
        }

        if (Input.touchCount > 0) {
           // text.text = (Input.GetTouch(0).position.ToString());
         
        }
    
    }


   
    void touch(Transform form) {
        GameObject hitObt = form.gameObject;
        text.text = hitObt.name;
        Destroy(hitObt);
    }
}
