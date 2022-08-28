// Dada uma string 's' contendo apenas os caracteres '(', ')', '{', e '}', determine se a string de entrada é válida.'['']'

// Uma string de entrada é válida se:

// Os colchetes abertos devem ser fechados pelo mesmo tipo de colchetes.
// Os colchetes abertos devem ser fechados na ordem correta.

class Program{
    static void Main(string[] args){
        var result = new Solution();
        
        string s =  "()";
        string s1 = "(]";
        string s2 = "()[]{}";
        string s3 = "]";
        string s4 = "(){}}{";
        string s5 = "(])";
        string s6 = "[])";
        string s7 = "[([]])";
        string s8 = "[";

        Console.WriteLine(result.IsValid(s));
        Console.WriteLine(result.IsValid(s1));
        Console.WriteLine(result.IsValid(s2));
        Console.WriteLine(result.IsValid(s3));
        Console.WriteLine(result.IsValid(s4));
        Console.WriteLine(result.IsValid(s5));
        Console.WriteLine(result.IsValid(s6));
        Console.WriteLine(result.IsValid(s7));
        Console.WriteLine(result.IsValid(s8));
    }
}
public class Solution {
    public bool IsValid(string s) {
        List<char> seq = new List<char>();
        string []paren = new string[] {")","]","}"};

        foreach (var item in s)
        {
            Console.Write(item);
        }
        Console.WriteLine();

        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine("s:{0}",s[i]);
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
            foreach (var item in seq)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            if (i == 0 && seq.Count == 0 || (paren.Contains(s[i].ToString()) && seq.Count == 0)){
                return false;
            }else{
                Console.WriteLine("s:{0} - seq:{1}",s[i], seq.Last());
                if (s[i] == seq[seq.Count-1])
                {
                    Console.WriteLine("igual ou seq {0}", seq.Last());
                    seq.RemoveAt(seq.Count-1);
                }else
                {
                    return false;
                }
                
                if(i == s.Length && seq.Count != 0){
                     return false;
                }
            }
        }
        Console.WriteLine(seq.Count);
        if (seq.Count != 0)
            return false;
            
        return true;
    }
}