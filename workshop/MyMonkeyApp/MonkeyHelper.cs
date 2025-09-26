using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMonkeyApp
{
    /// <summary>
    /// 원숭이 데이터 컬렉션을 관리하는 정적 헬퍼 클래스
    /// </summary>
    public static class MonkeyHelper
    {
        // 원숭이 데이터 컬렉션 (예시 데이터 하드코딩)
        private static readonly List<Monkey> monkeys = new List<Monkey>
        {
            new Monkey("카푸친", "지능이 높고 도구를 사용하는 작은 원숭이.", "중남미 열대우림", @"  (o.o)\n  /|_|\n   / \\") ,
            new Monkey("마카크", "사회성이 강하고 다양한 환경에 적응하는 원숭이.", "아시아, 북아프리카", @"  ('.')\n  /|_|\n   / \\") ,
            new Monkey("긴팔원숭이", "팔이 길고 나무 사이를 잘 이동하는 원숭이.", "동남아시아", @"  (o_o)\n  /|_|\n   / \\")
        };

        // 무작위 선택 카운트
        private static int randomPickCount = 0;

        /// <summary>
        /// 모든 원숭이 목록 반환
        /// </summary>
        public static List<Monkey> GetAllMonkeys() => monkeys;

        /// <summary>
        /// 이름으로 원숭이 찾기
        /// </summary>
        public static Monkey? FindByName(string name)
        {
            return monkeys.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// 무작위 원숭이 반환 및 카운트 증가
        /// </summary>
        public static Monkey GetRandomMonkey()
        {
            randomPickCount++;
            var rand = new Random();
            return monkeys[rand.Next(monkeys.Count)];
        }

        /// <summary>
        /// 무작위 선택된 횟수 반환
        /// </summary>
        public static int GetRandomPickCount() => randomPickCount;
    }
}
