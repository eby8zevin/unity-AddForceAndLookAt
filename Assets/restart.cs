using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{

	[SerializeField]
	KeyCode keyRes;
	
	void Update()
    {
    	if (Input.GetKey(keyRes))
    		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
