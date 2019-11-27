using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour
{
	public static bool falling = false;
	
	public static Vector3 playerStartLocation;

    // Start is called before the first frame update
    void Start()
    {
		falling = false;
		playerStartLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		if (falling)
		{
			transform.position -= new UnityEngine.Vector3(0,1f,0);
		}
    }
}
