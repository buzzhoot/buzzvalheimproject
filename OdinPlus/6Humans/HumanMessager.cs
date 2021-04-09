using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System;
using UnityEngine;
using System.Collections.Generic;

namespace OdinPlus
{
	public class HumanMessager : HumanVillager, Hoverable, Interactable, OdinInteractable
	{

		protected override void Awake()
		{
			base.Awake();
			ChoiceList = new string[2] { "$op_talk", "$op_human_quest_take" };
		}
		public override void Choice0()
		{
			Say("I need some help");//trans
		}
		public void Choice1()
		{
			if (!IsQuestReady())
			{
				return;
			}
			var key = m_nview.GetZDO().GetString("npcname");
			OdinData.AddKey(key);
			PlaceQuestHuman(key);
			Say("Thx, you can find him near in the woods");
			timer=QuestCD;
		}
		private void PlaceQuestHuman(string key)
		{
			//add
		}

	}
}
