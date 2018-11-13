using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sLowZoo
{
	public class Message : ScriptableObject
	{
		public Talk[] flow;

		[System.Serializable]
		public class Talk
		{
			public int id;
			public string name;
			public string message;
		}
	}
}