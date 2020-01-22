using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Practice3JaggedArray
{
	public class JaggedArray<T> : IEnumerable<T>
	{

		private List<T>[] _list;

		public JaggedArray(int rowmax)
		{
			_list = new List<T>[rowmax];
		}

		public void Add(int row, T val, params T[] restvals)
		{
			_list[row] = new List<T>();
			_list[row].Add(val);
			for (int i = 0; i < restvals.Length; i++)
			{
				_list[row].Add(restvals[i]);
			}
			Debug.Log(_list[row]);
		}

		public IEnumerator<T> GetEnumerator()
		{
			//各要素のリストをイテレート
			foreach (List<T> sublist in _list)
			{
				if (sublist != null)
				{
					//リストをイテレート
					foreach (T val in sublist)
					{
						yield return val;
					}
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
