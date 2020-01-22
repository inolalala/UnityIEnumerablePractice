using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleEnumerable
{
	public class SimpleIteratorMain : MonoBehaviour
	{
		private void Start()
		{
			EnumerableArray enumerableArray = new EnumerableArray();
			IEnumerator enumerator = enumerableArray.GetEnumerator();
			while(enumerator.MoveNext())
			{
				Debug.Log(enumerator.Current);
			}
		}
	}
}
