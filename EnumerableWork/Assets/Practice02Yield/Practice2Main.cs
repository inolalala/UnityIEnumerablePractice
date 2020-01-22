using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Practice2IteratorYield
{
	public class Practice2Main : MonoBehaviour
	{

		// Use this for initialization
		void Start()
		{
			MemberCollection memberCollection = new MemberCollection("bob","takeshi","Mary");
			foreach(var m in memberCollection)
			{
				Debug.Log(m.ToString());
			}
		}
	}
}

