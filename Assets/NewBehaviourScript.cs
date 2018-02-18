using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
public class trigger: MonoBehaviour {  
	void OnTriggerEnter(Collider cube) { 

		print ("collision detected");
		Destroy(cube.gameObject);  
	}
}
