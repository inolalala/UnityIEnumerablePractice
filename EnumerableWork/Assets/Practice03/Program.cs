using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var classRooms = GetClassRooms();

            var males = classRooms
                .SelectMany(c => c.Members.Where(m => m.Sex == SexType.Male))
                .OrderBy(m => m.Name)
                .ToList();
            var females = classRooms
                .SelectMany(c => c.Members.Where(m => m.Sex == SexType.Female))
                .OrderBy(m => m.Name)
                .ToList();

            males.ForEach(member => Console.WriteLine($"{member.Sex}の{member.Name}です！"));
            females.ForEach(member => Console.WriteLine($"{member.Sex}の{member.Name}です！"));

            Console.ReadLine();
        }


        public static List<Class> GetClassRooms()
        {
            return new List<Class>()
            {
                new Class(
                    1,
                    new Member("たけし", 0, SexType.Male),
                    new Member("のぶ", 1, SexType.Male),
                    new Member("花子", 2, SexType.Female)
                ),
                new Class(
                    2,
                    new Member("kate", 0, SexType.Female),
                    new Member("bob", 1, SexType.Male)
                ),
                new Class(
                    3,
                    new Member("nami", 0, SexType.Female),
                    new Member("soichiro", 1, SexType.Male),
                    new Member("akane", 2, SexType.Female),
                    new Member("tomoko", 3, SexType.Female)
                ),
                new Class(
                    4,
                    new Member("独眼竜二", 0, SexType.Male)
                ),
                new Class(
                    5,
                    new Member("一郎", 0, SexType.Male),
                    new Member("次郎", 1, SexType.Male),
                    new Member("三郎", 2, SexType.Male)
                )
            };
        }
    }


    public class Class
    {
        public int ClassNumber { get; private set; }
        private List<Member> _members = new List<Member>();

        public IEnumerable<Member> Members => _members;

        public Class(int classNumber)
        {
            ClassNumber = classNumber;
        }

        public Class(int classNumber, params Member[] members)
        {
            ClassNumber = classNumber;
            _members.AddRange((members.ToArray()));
        }

        public void AddMember(Member m)
        {
            _members.Add(m);
        }
    }

    public class Member
    {
        public string Name { get; private set; }
        public int Id { get; private set; }
        public SexType Sex { get; private set; }

        public Member(string name, int id, SexType sex)
        {
            Id = id;
            Name = name;
            Sex = sex;
        }
    }

    public enum SexType
    {
        Male,
        Female
    }
}