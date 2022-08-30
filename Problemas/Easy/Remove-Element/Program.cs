/*
27. Remove Element
Dado um array de inteiros nums e um inteiro val, remova todas as ocorrências de val em nums in-place . A ordem relativa dos elementos pode ser alterada.

Como é impossível alterar o comprimento do array em alguns idiomas, você deve colocar o resultado na primeira parte do array nums. Mais formalmente, se houver k elementos após a remoção das duplicatas, os primeiros k elementos de nums devem conter o resultado final. Não importa o que você deixa além dos primeiros k elementos.

Retorne k após colocar o resultado final nos primeiros k slots de nums.

Não aloque espaço extra para outra matriz. Você deve fazer isso modificando a matriz de entrada no local com memória extra O(1).
*/

class Program{
    static void Main(string[] args){
        var solution = new Solution();
        var nums = new int[] {3,2,2,3};
        int val = 3;

        Console.WriteLine(solution.RemoveElement(nums, val));
    }
}

public class Solution {
    public int RemoveElement(int[] nums, int val) {

        var temp = nums.Where(x => x != val).ToArray();
        
        for (int i = 0; i < temp.Length; i++)
        {
            nums[i] = temp[i];
        }

        return temp.Count();
    }
}

