// Escreva uma função para encontrar a string de prefixo comum mais longa entre uma matriz de strings.

// Se não houver prefixo comum, retorne uma string vazia "".

class Program{
    static void Main(string[] args){
        var result = new Solution();

        var strs = new string[] {"flower","flow","flight"};
        Console.WriteLine(result.LongestCommonPrefix(strs));
    }
}
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int letter = 0, word = 0;
        string str = "";

        if (strs[0] == "" || strs.Length == 1) return strs[0];

        while (true)
        {
            word++;
            if (strs[0].Length <= letter || strs[word].Length <= letter){
                break;
            }

            if (strs[0][letter] != strs[word][letter]){
                return str;
            }
            if ((strs.Length-1) == word){
                str += strs[0][letter].ToString();
                ++letter;
                word = 0;
            }
        }
        return str != null ? str : "";
    }
}
/*
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int step = 0, i = 0;
        bool pass = true;
        string str = "";

        if (strs[0] == "" || strs.Length == 1) return strs[0];

        while (true)
        {
            i++;
            if (step >= strs[0].Length) break;

            if (step >= strs[i].Length){
                pass = false;
            }else{
                if (strs[0][step] != strs[i][step]){
                    return str;
                }
            }
            if (i >= strs.Length-1){
                if (pass) str += strs[0][step].ToString();
                
                ++step;
                i = 0;
            }
        }
        return str != null ? str : "";
    }
}
*/