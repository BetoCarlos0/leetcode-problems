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

        // for (int i = 0; i < s.Length; i++)
        // {
        //     if (s[i] == '('){
        //         seq.Add(')');
        //     }
        //     if (s[i] == '['){
        //         seq.Add(']');
        //     }
        //     if (s[i] == '{'){
        //         seq.Add('}');
        //     }
        // }

        if (s.Length != seq.Count*2)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '('){
                seq.Add(')');
            }
            if (s[i] == '['){
                seq.Add(']');
            }
            if (s[i] == '{'){
                seq.Add('}');
            }

            Console.WriteLine("s:{0} - seq:{1}",s[i], seq.Last());
            if (s[i] == seq.Last())
            {
                Console.WriteLine(s[i]);
                seq.Remove(seq.Last());
            }
        }
        Console.WriteLine(seq.Count);
        if (seq.Count != 0)
            return false;
            
        return true;
    }
}