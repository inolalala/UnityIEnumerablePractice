using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Practice2IteratorYield
{
	public class MemberCollection : IEnumerable
	{
		string[] m_memberNames;

		public MemberCollection(params string[] memberNames)
		{
			m_memberNames = memberNames;
		}

		public IEnumerator GetEnumerator()
		{
			for (int i = 0; i < m_memberNames.Length; i++)
			{
				yield return m_memberNames[i];
			}
		}
	}
}
