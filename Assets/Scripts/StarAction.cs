using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAction : MonoBehaviour {
  bool highlighted = false;
  void OnMouseOver() {
    highlight();
  }
  void OnMouseExit() {
    unhighlight();
  }

  public void highlight() {
    if (highlighted) return;
    transform.localScale *= 2;
    highlighted = true;
  }
  public void unhighlight() {
    if (!highlighted) return;
    transform.localScale /= 2;
    highlighted = false;
  }
}
