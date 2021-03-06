﻿using UnityEngine;
using System.Collections;

namespace StateMachine.Action.Math{
	[Info (category = "Math", 
	       description = "Radians-to-degrees conversion constant ",
	       url = "http://docs.unity3d.com/ScriptReference/Mathf.Rad2Deg.html")]
	[System.Serializable]
	public class Rad2Deg : StateAction {
		[RequiredField(DefaultReference.Required,false,false)]
		[Tooltip("Store the result.")]
		public FloatParameter store;
			
		public override void OnEnter ()
		{
			base.OnEnter ();
			store.Value = Mathf.Rad2Deg;
		}
	}
}