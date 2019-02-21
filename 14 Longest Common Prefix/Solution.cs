public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0)
            return "";
        string currentPrefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            string str = strs[i];
            int j = 0;
            while ((j < currentPrefix.Length) && (j < str.Length) && (str[j] == currentPrefix[j]))
                j++;
            if (j == 0)
            {
                currentPrefix = "";
                break;
            }
            currentPrefix = currentPrefix.Substring(0, j);
        }
        return currentPrefix;
    }
}
