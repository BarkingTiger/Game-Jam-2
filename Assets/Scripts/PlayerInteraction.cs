using UnityEngine;
using System.Collections.Generic;
using System.Collections;
 
public class PlayerInteraction : MonoBehaviour {

    public GameObject Player;
    public GameObject note;
    public float minDist = 5f;
    public string text = "Spooky skeletons";
    float dist;
    bool reading = false;
    bool spawn = false;
    bool once = true;

    void Start() {
        note.SetActive(false);
    }

    void Update () {
        dist = Vector3.Distance(Player.gameObject.transform.position, gameObject.transform.position);
        if (dist <= minDist) {
            if(Input.GetKeyDown(KeyCode.E)) {
              if(reading) {
                  reading = false;
               }
               else {
                   reading = true;
                   spawn = true;
               }
         }
     }
      else {
         reading = false;
      }
    }
 
    void OnGUI() {
        if(reading) {
            GUI.TextArea(new Rect(Screen.height/2, Screen.width/2, 500, 500), text);
            if (spawn && once) {
                note.SetActive(true);
                once = false;
            }
        }
        else if(dist <= minDist) {
            GUI.TextArea(new Rect(Screen.height/2, Screen.width/2, 500, 500), "Press 'E' to read.");
        }
    }
}