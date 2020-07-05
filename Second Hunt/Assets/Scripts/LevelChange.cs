using UnityEngine;
using System.Collections;
 
public class LevelChange: MonoBehaviour {
 
void Update(){
if(Input.GetKeyDown(KeyCode.Alpha1)){
Application.LoadLevel("Sanctorus");
}
if(Input.GetKeyDown(KeyCode.Alpha2)){
Application.LoadLevel("arcterra");
}
}
}