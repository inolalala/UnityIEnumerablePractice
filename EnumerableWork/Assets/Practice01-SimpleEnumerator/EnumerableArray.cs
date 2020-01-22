using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleEnumerable
{
	public class EnumerableArray : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			return new ArrayEnumerator();
		}

		class ArrayEnumerator : IEnumerator
		{

			public int[] value;
			public int index;

			public ArrayEnumerator()
			{
				index = -1;
				value = new int[5];
				value[0] = 10;
				value[1] = 20;
				value[2] = 30;
				value[3] = 40;
				value[4] = 50;
			}

			public object Current
			{ 
				get
				{
					return value[index];
				}
			}

			public bool MoveNext()
			{
				index++;
				return (index < value.Length);
			}

			public void Reset()
			{
				index = -1;
			}
		}
	}
}
