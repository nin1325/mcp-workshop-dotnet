using System;

namespace MyMonkeyApp
{
    /// <summary>
    /// 원숭이 정보를 담는 데이터 모델 클래스
    /// </summary>
    public class Monkey
    {
        public string Name { get; set; }         // 원숭이 이름
        public string Description { get; set; }  // 간단한 설명
        public string Habitat { get; set; }      // 서식지
        public string AsciiArt { get; set; }     // ASCII 아트

        public Monkey(string name, string description, string habitat, string asciiArt)
        {
            Name = name;
            Description = description;
            Habitat = habitat;
            AsciiArt = asciiArt;
        }
    }
}
