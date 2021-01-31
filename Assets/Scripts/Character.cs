using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
  public int dist = 550;
  public int size = 75;
  public GameObject starTemplate;

  private GameObject outline;
  private GameObject stars;

  void Start() {
    outline = transform.Find("lines").gameObject;
    outline.SetActive(false);
    stars = transform.Find("stars").gameObject;
    placeCharacter();
  }

  public void highlight() {
    outline.gameObject.SetActive(true);
    //outline.gameObject.GetComponent<OutlineAction>().highlight();
    foreach (Transform star in stars.transform) {
      star.gameObject.GetComponent<StarAction>().highlight();
    }
  }
  public void unhighlight() {
    outline.gameObject.SetActive(false);
    //outline.gameObject.GetComponent<OutlineAction>().unhighlight();
    foreach (Transform star in stars.transform) {
      star.gameObject.GetComponent<StarAction>().unhighlight();
    }
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
