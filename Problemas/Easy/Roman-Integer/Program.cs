// Por exemplo,  2é escrito como II em numeral romano, apenas dois somados. 12é escrito como  XII, que é simplesmente X + II. O número 27é escrito como XXVII, que é XX + V + II.

// Os algarismos romanos são geralmente escritos do maior para o menor da esquerda para a direita. No entanto, o numeral para quatro não é IIII. Em vez disso, o número quatro é escrito como IV. Porque o um está antes do cinco, nós o subtraímos fazendo quatro. O mesmo princípio se aplica ao número nove, que é escrito como IX. Há seis casos em que a subtração é usada:

// Ipode ser colocado antes Vde (5) e X(10) para fazer 4 e 9. 
// Xpode ser colocado antes de L(50) e C(100) para fazer 40 e 90. 
// Cpode ser colocado antes D(500) e M(1000) para fazer 400 e 900.
// Dado um numeral romano, converta-o em um número inteiro.

class Program{
    static void Main(string[] args){
        var result = new Solution();
        //Console.WriteLine(result.RomanToInt("XX"));
        //Console.WriteLine(result.RomanToInt("XX"));
        //Console.WriteLine(result.RomanToInt("XX"));
        //Console.WriteLine(result.RomanToInt("XX"));
        //Console.WriteLine(result.RomanToInt("XX"));
        Console.WriteLine(result.RomanToInt("XC"));
        Console.WriteLine(result.RomanToInt("XL"));
        Console.WriteLine(result.RomanToInt("IV"));
        Console.WriteLine(result.RomanToInt("IC"));
    }
}

public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        for (int i = s.Length-1; i >= 0; i--)
        {
            if (s[i] == 'M') result += 1000;

            if (s[i] == 'D') result += 500;

            if (s[i] == 'C'){
                if (i+1 <= s.Length-1){
                    if (s[i+1] == 'D' || s[i+1] == 'M') result -= 200;
                }
                result += 100;
            }
            if (s[i] == 'L') result += 50;

            if (s[i] == 'X'){
                if (i+1 <= s.Length-1){
                    if (s[i+1] == 'L' || s[i+1] == 'C') result -= 20;
                }
                result += 10;
            }
            if (s[i] == 'V') result += 5;

            if (s[i] == 'I'){
                if (i+1 <= s.Length-1){
                    if (s[i+1] == 'V' || s[i+1] == 'X') result -= 2;
                }
                result += 1;
            }
        }
        return result;
    }
}
