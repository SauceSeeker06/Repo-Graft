// (c) Copyright HutongGames, LLC 2010-2023. All rights reserved.
// THIS CONTENT IS AUTOMATICALLY GENERATED. __PLAYMAKER_EVENT_PROXY__
// this script was generated by the 'PlayMaker Event Proxy Wizard'. You can edit this script directly now, but prefer using the wizard if you are not sure.

using UnityEngine;
using HutongGames.PlayMaker.Ecosystem.Utils;
using HutongGames.PlayMaker;

namespace com.yourdomain
{
	public class AttackHitCheckProxy : PlayMakerEventProxy {

		[Button("AttackHitCheck","Test : AttackHitCheck")] public bool _;
		public void AttackHitCheck()
		{
			if (debug || !Application.isPlaying)
			{
				Debug.Log("AttackHitCheckProxy : AttackHitCheck()");
			}

            

			base.SendPlayMakerEvent();
		}
	}
}