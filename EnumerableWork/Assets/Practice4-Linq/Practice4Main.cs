using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Practice4
{
	public class Practice4Main : MonoBehaviour
	{
		
		private void Start()
		{
			var enumerable = Enumerable.Range(0, 100).ToArray();
			var sannobaisu = enumerable.Where(e => e % 3 == 0).ToList();
			sannobaisu.ForEach(s => Debug.Log(s.ToString()+"なのでアホになっちゃう！"));
		}
	}
}
