using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadescript : MonoBehaviour {

    public GameObject fadeObject;
    GameLogic gameLogic;
    
	// Use this for initialization
	void Start ()
    {

    }
    IEnumerator StartOver()
   {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Update is called once per frame
    void Update ()
    {
            StartCoroutine(StartOver());
	}
}
