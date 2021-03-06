﻿using UnityEngine;
using System.Collections;

namespace StateMachine.Action{
	[Info (category = "Transform",   
	       description = "",
	       url = "")]
	[System.Serializable]
	public class GetEulerAngles : GameObjectAction {
		[RequiredField(DefaultReference.Required,false,false)]
		[Tooltip("Store the result.")]
		public Vector3Parameter store;
		[Tooltip("Execute the action every frame.")]
		public bool everyFrame;

		public override void OnEnter ()
		{
			base.OnEnter ();
			if(!enabled) {
				return;			
			}
			store.Value = ((GameObject)gameObject.Value).transform.rotation.eulerAngles;
			if (!everyFrame) {
				Finish ();
			}
		}

		public override void OnUpdate ()
		{
			store.Value = ((GameObject)gameObject.Value).transform.rotation.eulerAngles;
		}
	}
}