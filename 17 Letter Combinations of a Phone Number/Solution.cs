public class Solution {
    private Dictionary<char, string> digitLetters = new Dictionary<char, string>{{'2', "abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"}, {'6', "mno"}, {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}};
    
    public IList<string> LetterCombinations(string digits) {
      List<string> result = new List<string>{};
      PartialCombinations(digits, "", result);
        return result;
    }
    private void PartialCombinations(string digits, string word, List<string> result) {
      if (digits.Length > 0){
          string letters = digitLetters[digits[0]];
          foreach(char letter in letters)
          {
            PartialCombinations(digits.Substring(1, digits.Length - 1), word + letter, result);
          }
      }
        else
        {
            if (word != "")
             result.Add(word);
        }
        
    }
}