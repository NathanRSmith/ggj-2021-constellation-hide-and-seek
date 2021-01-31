using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour {
  public int dist = 550;
  public int size = 75;
  public GameObject starTemplate;

  private GameObject outline;
  private GameObject stars;

  void Start() {
    outline = transform.Find("lines").gameObject;
    stars = transform.Find("stars").gameObject;
    placeCharacter();
  }


  private void placeCharacter() {
    // get location on sphere
    var rand = Random.onUnitSphere * dist;
    rand.y = Mathf.Abs(rand.y);
    transform.position = rand;

    // orient toward camera
    transform.rotation = Quaternion.LookRotation(transform.position - Vector3.zero);

    // size
    transform.localScale = new Vector3(size, size, size);


    // TODO: rotate wrt to camera
  }

}
