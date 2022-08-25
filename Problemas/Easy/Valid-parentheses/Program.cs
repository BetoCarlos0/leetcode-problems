// Dada uma string 's' contendo apenas os caracteres '(', ')', '{', e '}', determine se a string de entrada é válida.'['']'

// Uma string de entrada é válida se:

// Os colchetes abertos devem ser fechados pelo mesmo tipo de colchetes.
// Os colchetes abertos devem ser fechados na ordem correta.

class Program{
    static void Main(string[] args){
        var result = new Solution();
        
        string s = "()";
        Console.WriteLine(result.IsValid(s));
    }
}
public class Solution {
    public bool IsValid(string s) {
        string []count = new string[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                
            }
        }
        return false;
    }
}