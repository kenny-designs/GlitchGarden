using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour {
  [SerializeField] float waitInSeconds = 4f;

  int currentSceneIndex;

  private void Start() {
    currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    if (currentSceneIndex == 0) {
      StartCoroutine(WaitForTime());
    }
  }

  IEnumerator WaitForTime() {
    yield return new WaitForSeconds(waitInSeconds);
    LoadNextScene();
  }

  public void LoadNextScene() {
    SceneManager.LoadScene(currentSceneIndex + 1);
  }
}
