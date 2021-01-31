using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStarAction : MonoBehaviour {
  void OnMouseOver() {
    transform.parent.parent.gameObject.GetComponent<Character>().highlight();
  }
  void OnMouseExit() {
    transform.parent.parent.gameObject.GetComponent<Character>().unhighlight();
  }
}
