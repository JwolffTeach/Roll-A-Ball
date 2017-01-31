using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSettings : MonoBehaviour {

    public int score = 0;
    public int level = 1;

    void Awake() {

        // Do not destroy this game object:

        DontDestroyOnLoad(transform.gameObject);

    }
    // Use this for initialization
    void Start () {
        Debug.Log(level);
	}
	
	// Update is called once per frame
	void Update () {
        if (score < 3) {
            //Debug.Log(score);
        }
        else {
            level += 1;
            newLevel(level);
            score = 0;
            Debug.Log(level);
        }
	}

    void newLevel(int levelUp) {
        Debug.Log(levelUp);
        if (levelUp == 2)
            SceneManager.LoadScene("walls2");
        if (levelUp == 3)
            SceneManager.LoadScene("walls3");
    }
}
