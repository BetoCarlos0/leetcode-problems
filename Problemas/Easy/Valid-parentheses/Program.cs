// Dada uma string 's' contendo apenas os caracteres '(', ')', '{', e '}', determine se a string de entrada é válida.'['']'

// Uma string de entrada é válida se:

// Os colchetes abertos devem ser fechados pelo mesmo tipo de colchetes.
// Os colchetes abertos devem ser fechados na ordem correta.

class Program{
    static void Main(string[] args){
        var result = new Solution();
        
        string s = "()[]{}";
        Console.WriteLine(result.IsValid(s));
    }
}
public class Solution {
    public bool IsValid(string s) {
        List<char> seq = new List<char>();
        string []paren = new string[] {")","]","}"};


        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '('){
                seq.Add(')');
                continue;
            }
            if (s[i] == '['){
                seq.Add(']');
                continue;
            }
            if (s[i] == '{'){
                seq.Add('}');
                continue;
            }

            if (i == 0 && seq.Count == 0 || (paren.Contains(s[i].ToString()) && seq.Count == 0)){
                return false;
            }else{
                if (s[i] == seq[seq.Count-1]) seq.RemoveAt(seq.Count-1);
                else return false;
                
                if(i == s.Length && seq.Count != 0)
                     return false;
            }
        }
        if (seq.Count != 0)
            return false;
            
        return true;
    }
}