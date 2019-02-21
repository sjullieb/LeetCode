public class Solution {
    public int Reverse(int x) {
        string str = x.ToString();
        string result = "";
        bool minus = false;
        if (str[0] == '-')
        {
            str = str.Substring(1, str.Length - 1);
            minus = true;
        }
        char[] charArray = str.ToCharArray();
        Array.Reverse( charArray );
        result = new string( charArray );
        
        // --------------- version 2 ------------
        
/*         for(int i = str.Length - 1; i>=0; i--)
         {
             if (str[i] != '-')
                 result = result + str[i];
         }*/
        
        try
        {
            if (minus)
            {
                Console.WriteLine("-" + result);   
                return int.Parse("-" + result);
            }
            else
                return int.Parse(result);
        }
        catch(OverflowException)
        {
            return 0;
        }
    }
}