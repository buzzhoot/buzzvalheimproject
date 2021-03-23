using System;
using UnityEngine;
namespace OdinPlus
{
	public static class Tweakers
	{
		public static Humanoid ChangeSpeed(this Humanoid humanoid, float speed)
		{
			humanoid.m_speed = speed;
			return humanoid;
		}
		public static Tutorial.TutorialText SendRavenMessage(string messageName, string messageText)
		{
			Tutorial.TutorialText tutorialText = new Tutorial.TutorialText
			{
				m_label = "OdinQuest",
				m_name = messageName,
				m_text = messageText,
				m_topic = "Quest Hints"
			};
			if (!Tutorial.instance.m_texts.Contains(tutorialText))
			{
				Tutorial.instance.m_texts.Add(tutorialText);
			}
			Player.m_localPlayer.ShowTutorial(tutorialText.m_name, true);
			return tutorialText;
		}
		public static string GetTransName(this string str)
		{
			return ObjectDB.instance.GetItemPrefab(str).GetComponent<ItemDrop>().m_itemData.m_shared.m_name;
		}
		public static string GetLocal(this string str)
		{
			return Localization.instance.Localize(str);
		}
		public static string DepakVector2i(this string str, Vector2i v2i)
		{
			return v2i.x.ToString() + "_" + v2i.y.ToString();
		}
		public static Vector2i Pak(this Vector2i val, string str)
		{
			string[] a = str.Split(new char[] { '_' });
			val.x = int.Parse(a[0]);
			val.y = int.Parse(a[1]);
			return val;
		}
	}

}