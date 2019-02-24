public class Solution {
    
    public int[] SearchRange(int [] arr, int target)
    {
    
        int min = -1;
        int max = -1;        
        
        if (arr.Length > 0)
        {
            int l = 0;
            int r = arr.Length -1;    
            while (l+1 < r)
            {
                int m = (r-l)/2 + l;
                if (arr[m] < target)
                    l = m;
                else
                    r = m;
            }
            if (arr[r] == target)
                min = r;
            if (arr[l] == target)
                min = l;
            
    Console.WriteLine("{0} {1}", l, r);
            
            l = 0;
            r = arr.Length -1;             
            while (l+1 < r)
            {
                int m = (r-l)/2 + l;
                if (arr[m] > target)
                    r = m;
                else
                    l = m;
            }
            if (arr[l] == target)
                max = l;
            if (arr[r] == target)
                max = r;
    Console.WriteLine("{0} {1}", l, r);            
        }     
        
        int[] result = {min, max};
        return result;
    }
}