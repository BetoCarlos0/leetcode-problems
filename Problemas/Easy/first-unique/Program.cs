// Dada uma string s, encontre o primeiro caractere não repetido e retorne seu índice. Se não existir, retorne -1.

class Program{
    static void Main(string[] args){
        var result = new Solution();
        Console.WriteLine(result.FirstUniqChar("loveleetcode"));
    }
}

public class Solution {
    public int FirstUniqChar(string s) {
        var dic = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!dic.Contains(s[i]))
            {
                if (!s.Skip(i+1).Contains(s[i]))
                {
                    return i;
                }
                else
                {
                    dic.Add(s[i]);    
                }
            }
        }
        return -1;
    }
}