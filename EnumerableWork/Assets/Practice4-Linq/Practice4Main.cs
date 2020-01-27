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
			//var sannobaisu = enumerable.Where(e => e % 3 == 0).ToList();
			//sannobaisu.ForEach(s => Debug.Log(s.ToString()+"なのでアホになっちゃう！"));

			//var sannonbaisunijyo = enumerable.Where(e => e % 3 == 0).Select(e => e * e).ToList();
			//sannonbaisunijyo.ForEach(s => Debug.Log(s.ToString() + "なので2乗のアホになっちゃう！"));

			//var sannonbaisunijyo = enumerable.Where(e => e % 3 == 0).Select(e => e * e).Skip(1).ToList();
			//sannonbaisunijyo.ForEach(s => Debug.Log(s.ToString() + "なので2乗のアホになっちゃう！"));

			var sanjyumadetoru = enumerable.TakeWhile(e => e <= 30).ToList();
			sanjyumadetoru.ForEach(s => Debug.Log(s.ToString() + "は30より大きくない"));
		}
	}
}
