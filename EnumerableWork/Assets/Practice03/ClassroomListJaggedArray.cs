using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Practice3JaggedArray
{
	public class ClassroomListJaggedArray : IEnumerable
	{
		//List<Member>の配列
		private List<MemberInfo>[] m_memberInfoList;

		public ClassroomListJaggedArray(int rowmax)
		{
			m_memberInfoList = new List<MemberInfo>[rowmax];
		}

		public List<MemberInfo>[] MemberInfoList
		{
			get
			{
				return m_memberInfoList;
			}

			set
			{
				m_memberInfoList = value;
			}
		}

		public void Add(int row, MemberInfo val, params MemberInfo[] restvals)
		{
			m_memberInfoList[row] = new List<MemberInfo>();
			List<MemberInfo> classroomInfo = m_memberInfoList[row];

			classroomInfo.Add(val);
			for(int i=0; i<restvals.Length; i++)
			{
				classroomInfo.Add(restvals[i]);
			}
		}


		public IEnumerator GetEnumerator()
		{
			foreach(List<MemberInfo> memberInfos in m_memberInfoList)
			{
				if(memberInfos != null)
				{
					foreach(MemberInfo info in memberInfos)
					{
						yield return info;
					}
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}

	public class MemberInfo
	{
		private string m_name;
		private int m_id;
		private SexType m_sex;

		public MemberInfo(string name, int id, SexType sex)
		{
			m_name = name;
			m_id = id;
			m_sex = sex;
		}

		public string Name
		{
			get
			{
				return m_name;
			}

			set
			{
				m_name = value;
			}
		}

		public int Id
		{
			get
			{
				return m_id;
			}

			set
			{
				m_id = value;
			}
		}

		public SexType Sex
		{
			get
			{
				return m_sex;
			}

			set
			{
				m_sex = value;
			}
		}
	}
	public enum SexType
	{
		Male,
		Female
	}
}
