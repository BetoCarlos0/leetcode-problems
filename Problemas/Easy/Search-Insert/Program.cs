/*
Dada uma matriz ordenada de inteiros distintos e um valor de destino, retorne o índice se o destino for encontrado. Caso contrário, retorne o índice onde estaria se fosse inserido em ordem.

Você deve escrever um algoritmo com  O(log n)complexidade de tempo de execução.
*/

class Program{
    static void Main(string[] args){
        var solution = new Solution();
        int []nums = new int[] {1,3,5,6};
        int target = 5;

        Console.WriteLine(solution.SearchInsert(nums, target));
    }
}

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        

        return 0;
    }
}