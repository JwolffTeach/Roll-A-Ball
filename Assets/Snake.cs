using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour {

    private ParticleSystem ps;

    public float lifeTime = 0.1f;
    public float lengthModifier = 0.1f;

	// Use this for initialization
	void Start () {
        ps = gameObject.GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Upgrade() {
        lifeTime = lifeTime + lengthModifier;
        ps.startLifetime = lifeTime;
    }
}
