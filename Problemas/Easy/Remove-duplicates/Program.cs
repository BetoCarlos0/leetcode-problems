/*
26 . Remover duplicatas da matriz classificada

Dada uma matriz de inteiros numsclassificada em ordem não decrescente , remova as duplicatas no local, de modo que cada elemento exclusivo apareça apenas uma vez . A ordem relativa dos elementos deve ser mantida a mesma .

Como é impossível alterar o comprimento do array em alguns idiomas, você deve colocar o resultado na primeira parte do array nums. Mais formalmente, se houver kelementos após a remoção das duplicatas, os primeiros kelementos de nums devem conter o resultado final. Não importa o que você deixa além dos primeiros  k elementos.

Retorne kapós colocar o resultado final nos primeiros kslots denums .

Não aloque espaço extra para outra matriz. Você deve fazer isso modificando a matriz de entrada no local com memória extra O(1).
*/

class Program{
    static void Main(string[] args){
        var solution = new Solution();
        int[] nums = new int[] {1,1,2};

        Console.WriteLine("--",solution.RemoveDuplicates(nums));
    }
}

public class Solution {
    public int RemoveDuplicates(int[] nums) {

        var temp = nums.Distinct().ToArray();

        for (int i = 0; i < temp.Length; i++)
        {
            nums[i] = temp[i];
        }

        return temp.Length;
    }
}
