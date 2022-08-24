//Dado um inteiro x, retorne truese xfor um inteiro palíndromo.

//Um inteiro é um palíndromo quando lê o mesmo para trás e para frente.

//Por exemplo, 121é um palíndromo enquanto 123não é.

class Program{
    static void Main(string[] args){
        var result = new Solution();
        Console.WriteLine(result.IsPalindrome(-121));
    }
}

public class Solution {
    public bool IsPalindrome(int x) {
        string s = Convert.ToString(x);
        for (int i = 0; i < s.Length/2; i++)
        {
            if (s[i] != s[s.Length-(i+1)])
            {
                return false;
            }
        }
        return true;
    }
}

