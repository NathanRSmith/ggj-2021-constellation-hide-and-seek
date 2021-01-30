using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Camera-Control/Character Outline")]
public class CharacterOutline : MonoBehaviour {
  public int dist = 550;
  public int size = 100;
  public GameObject outlineTemplate;
  public GameObject outline;
  public GameObject starsTemplate;
  public GameObject stars;


  // Start is called before the first frame update
  void Start() {
    placeCharacter();
  }


  void placeCharacter() {
    //// lines
    //outline = Instantiate(outlineTemplate, )


    // get location on sphere
    var rand = Random.onUnitSphere * dist;
    rand.y = Mathf.Abs(rand.y);
    transform.position = rand;

    // orient toward camera
    transform.rotation = Quaternion.LookRotation(transform.position - Vector3.zero);
    //transform.LookAt(Vector3.zero);

    // size
    transform.localScale = new Vector3(size, size, size);


    // TODO: rotate wrt to camera
  }
}
