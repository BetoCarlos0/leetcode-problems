/*
Implemente strStr() .

Dadas duas strings needleand haystack, retorne o índice da primeira ocorrência de needlein haystack, ou -1se needlenão fizer parte de haystack.

Esclarecimento:

O que devemos retornar quando needleé uma string vazia? Esta é uma ótima pergunta para fazer durante uma entrevista.

Para o propósito deste problema, retornaremos 0 quando needlefor uma string vazia. Isso é consistente com strstr() do C e indexOf() do Java .
*/

class Program{
    static void Main(string[] args){
        var solution = new Solution();
        string haystack = "hello", needle = "lle";

        Console.WriteLine(solution.StrStr(haystack, needle));
    }
}

public class Solution {
    public int StrStr(string haystack, string needle) {

        return haystack.IndexOf(needle);
    }
}
