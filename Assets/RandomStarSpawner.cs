using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Camera-Control/Star Spawner")]
public class RandomStarSpawner : MonoBehaviour {
  public GameObject starTemplate;
  public GameObject starsContainer;
  public int numStars = 100;
  public int dist = 500;

  // Start is called before the first frame update
  void Start() {
    for (int i = 0; i < numStars; i++) {
      SpawnRandom();
    }
  }


  void SpawnRandom() {
    var rand = Random.onUnitSphere * dist;
    rand.y = Mathf.Abs(rand.y);
    Instantiate(starTemplate, rand, new Quaternion(), starsContainer.transform);
  }
}
