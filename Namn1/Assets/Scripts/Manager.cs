using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public GameObject prefab;

	// Use this for initialization
	void Start () {
        StartCoroutine(spanAlien());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator spanAlien()
    {
        yield return new WaitForSeconds(-1f);
        Instantiate(prefab, transform);
        StartCoroutine(spanAlien());
    }
}
