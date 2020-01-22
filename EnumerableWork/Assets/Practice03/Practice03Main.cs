using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using ConsoleApp1;

namespace Practice3JaggedArray
{
	public class Practice03Main : MonoBehaviour
	{
		private void Start()
		{

			ClassroomListJaggedArray classroomListJaggedArray = setup();
			int classroomNumber = classroomListJaggedArray.MemberInfoList.Length;

			var result = classroomListJaggedArray.MemberInfoList;
			List<MemberInfo> males = new List<MemberInfo>();
			for (int i = 0; i < classroomNumber; i++)
			{
				//ここで例えば「男性メンバーのMemberInfoを引っ張ってくる」的なことをしたい
				males.AddRange(result[i].Where(s => s.Sex == SexType.Male));
			}
			foreach (var m in males)
			{
				Debug.Log("俺は" + m.Name);
			}

			Debug.Log("//////////////////////////////////////");

			List<MemberInfo> female = new List<MemberInfo>();
			for (int i = 0; i < classroomNumber; i++)
			{
				//ここで例えば「男性メンバーのMemberInfoを引っ張ってくる」的なことをしたい
				female.AddRange(result[i].Where(s => s.Sex == SexType.Female));
			}
			foreach (var f in female)
			{
				Debug.Log("あたしは" + f.Name);
			}
		}

		//ここはいずれspreadsheetと連携してみたい
		private ClassroomListJaggedArray setup()
		{
			ClassroomListJaggedArray jArray = new ClassroomListJaggedArray(5);
			jArray.Add(
				0,
				new MemberInfo("たけし", 0, SexType.Male),
				new MemberInfo("のぶ", 1, SexType.Male),
				new MemberInfo("花子", 2, SexType.Female)
				);
			jArray.Add(
				1,
				new MemberInfo("kate", 0, SexType.Female),
				new MemberInfo("bob", 1, SexType.Male)
				);
			jArray.Add(
				2,
				new MemberInfo("nami", 0, SexType.Female),
				new MemberInfo("soichiro", 1, SexType.Male),
				new MemberInfo("akane", 2, SexType.Female),
				new MemberInfo("tomoko", 3, SexType.Female)
				);
			jArray.Add(
				3,
				new MemberInfo("独眼竜二", 0, SexType.Male)
				);
			jArray.Add(
				4,
				new MemberInfo("一郎", 0, SexType.Male),
				new MemberInfo("次郎", 1, SexType.Male),
				new MemberInfo("三郎", 2, SexType.Male)
				);

			return jArray;
		}
	}
}
