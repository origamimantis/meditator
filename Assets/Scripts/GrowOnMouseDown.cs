using UnityEngine;
using System.Collections;

public class GrowOnMouseDown : MonoBehaviour 
{
	private bool isGrowing = false;


	void Update()
	{
		if (isGrowing == false)
		{
			if (this.transform.localScale.x > 1 ||
				this.transform.localScale.y > 1 ||
				this.transform.localScale.y > 1)
			{
				this.transform.localScale -= new Vector3(0.1f,0.1f,0.1f);
			}
			else 
			{
				this.transform.localScale = new Vector3(1,1,1);
			}
		}
		else
		{
			this.transform.localScale += new Vector3(0.1f,0.1f,0.1f);
		}

	}

	void OnMouseDown()
	{
		isGrowing = true;
	}

	void OnMouseUp()
	{
		isGrowing = false;
	}

}
