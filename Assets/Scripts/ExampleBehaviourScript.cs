/*
 * This program is for changing color of cube by pressing key on keyboard
 */

using UnityEngine;

public class ExampleBehaviourScript : MonoBehaviour {

    #region private variables

    private Material _mat;

    #endregion

    #region unity buildin functions

    // Use this for initialization
    void Start () {
        _mat = GetComponent<Renderer>().material;
	}
	
    /// <summary>
    /// When specified key is press change color.
    /// </summary>
	// Update is called once per frame
	void Update () {

        //When hit 'R' key on keyboard change color of cube to red
        if (Input.GetKeyDown(KeyCode.R))
        {
            _mat.color = Color.red;
        }

        //When hit 'G' key on keyboard change color of cube to green
        if (Input.GetKeyDown(KeyCode.G))
        {
            _mat.color = Color.green;
        }

        //When hit 'B' key on keyboard change color of cube to blue
        if (Input.GetKeyDown(KeyCode.B))
        {
            _mat.color = Color.blue;
        }

    }
    #endregion

}
