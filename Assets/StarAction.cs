using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAction : MonoBehaviour {
  bool highlighted = false;
  void OnMouseOver() {
    if (highlighted) return;
    transform.localScale *= 2;
    highlighted = true;
  }
  void OnMouseExit() {
    transform.localScale /= 2;
    highlighted = false;
  }
}
