using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXSpace : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.U))
		{
			this.transform.position += new Vector3(0,1f,0);
		}
		if (Input.GetKey(KeyCode.D))
		{
			this.transform.position -= new Vector3(0,1f,0);
		}
    }
}
