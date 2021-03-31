using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountCharacters
{
    public class Data
    {
        public int Occurrence { get; set; }
        public char Character { get; set; }
    }

    public class CalculateOccurrence
    {
        public string InputString { get; set; }
        public Data[] Datas { get; set; }
        public CalculateOccurrence(string input)
        {
            InputString = input;
            Datas = new Data[26];
            SetData();
        }

        void SetData()
        {
            for (int i = 0; i < 26; i++)
            {
                Datas[i] = new Data
                {
                    Character = (char)(i + 65)
                };
            }
        }

        public void FindCharacterOccureceInString()
        {
            char[] chars = InputString.ToCharArray();
            for (int counter = 0; counter < chars.Length; counter++)
            {
                char currentChar = chars[counter];
                if (currentChar >= 97 && currentChar <= 122)
                {
                    // small letter, subtract 97
                    Datas[currentChar - 97].Occurrence++;
                }
                else if (currentChar >= 65 && currentChar <= 90)
                {
                    // Capital letter, subtract 65
                    Datas[currentChar - 65].Occurrence++;
                }
            }
        }

        public List<Data> FilterValidData()
        {
            return Datas.Where(x => x.Occurrence > 0).ToList();
        }

        public string PrintData()
        {
            var charactersInString = FilterValidData();
            var stringBuilder = new StringBuilder();
            foreach (var item in charactersInString)
            {
                stringBuilder.Append($"{item.Character} = {item.Occurrence}\n");
            }
            return stringBuilder.ToString();
        }
    }
}