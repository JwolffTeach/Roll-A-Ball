using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public Color ballColor;
    public Color colorStart = Color.red;
    public Color colorEnd = Color.green;
    public float duration = 2.5F;
    public Renderer rend;
    public int count = 0;
    public Color nextColor;
    public GameObject gameSettings;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
	}

    // Update is called once per frame
    void Update() {
        changeColors();
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            rend.material.color = nextColor;
            nextColor = Color.green;
        }
    }

    void changeColors() {
        rend.material.color = Color.blue;// = Color.red;// Lerp(colorStart, colorEnd, lerp);// ("_SpecColor", Color.blue);
        nextColor = Color.red;
    }
}
