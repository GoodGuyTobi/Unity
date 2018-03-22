using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {


    IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.transform.gameObject);
    }

}
