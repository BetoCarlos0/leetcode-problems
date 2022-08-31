/*
3. Longest Substring Without Repeating Characters
Dada uma string s, encontre o comprimento da substring mais longa sem repetir caracteres.
*/

class Program{
    static void Main(string[] args){
        var solution = new Solution();
        string s = "dvdf";

        Console.WriteLine(solution.LengthOfLongestSubstring(s));
    }
}

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        char []temp = new char[s.Length];
        int j = 1, max = 1;

        if (s.Length == 0) return 0;
        temp[0] = s[0];

        for (int i = 1; i < s.Length; i++)
        {
            if (!temp.Contains(s[i])){
                temp[j] = s[i];

            }else{

                Array.Clear(temp);
                i -= (j-1); 
                j = 0;
                temp[j] = s[i];
            }
            ++j;
            if (j > max) ++max;
        }
        return max;
    }
}