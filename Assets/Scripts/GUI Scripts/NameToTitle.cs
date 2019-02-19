using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NameToTitle : MonoBehaviour {

	public Text title;


	void OnMouseEnter()
	{
		switch(name)
		{
		case "Pac-Man":
			title.color = Color.yellow;
              title.text = "PEG Man";
             break;

		case "Blinky":
			title.color = Color.red;
                title.text = "Immune system";
                break;

		case "Pinky":
			title.color = new Color(254f/255f, 152f/255f, 203f/255f);
                title.text = "Metabolic enzyme";
                break;

		case "Inky":
			title.color = Color.cyan;
                title.text = "Pharmacokinetics";
                break;

		case "Clyde":
			title.color = new Color(254f/255f, 203f/255f, 51f/255f);
                title.text = "Liver";
                break;
		}
		
		
	}

	void OnMouseExit()
	{
		title.text = "PEG Man";
		title.color = Color.white;
	}
}
