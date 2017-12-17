using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AkButtonTrigger:AkTriggerBase { 

	void Start()
	{
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(onClick);
	}

	void onClick() { 
		if(triggerDelegate != null) { 
			triggerDelegate(null); 
		} 
	} 
}