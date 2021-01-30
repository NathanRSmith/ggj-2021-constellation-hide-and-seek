using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Camera-Control/Star Spawner")]
public class RandomStarSpawner : MonoBehaviour {
  public GameObject starTemplate;
  public GameObject starsContainer;
  public int numStars = 100;
  public int dist = 500;
  public int size = 5;

  // Start is called before the first frame update
  void Start() {
    for (int i = 0; i < numStars; i++) {
      SpawnRandom();
    }
  }


  void SpawnRandom() {
    var rand = Random.onUnitSphere * dist;
    rand.y = Mathf.Abs(rand.y);
    var obj = Instantiate(starTemplate, rand, new Quaternion(), starsContainer.transform);
    obj.transform.localScale = new Vector3(size, size, size);
  }
}
