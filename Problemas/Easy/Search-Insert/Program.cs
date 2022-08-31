/*
35. Search Insert Position
Dada uma matriz ordenada de inteiros distintos e um valor de destino, retorne o índice se o destino for encontrado. Caso contrário, retorne o índice onde estaria se fosse inserido em ordem.

Você deve escrever um algoritmo com  O(log n)complexidade de tempo de execução.
*/

class Program{
    static void Main(string[] args){
        var solution = new Solution();
        int []nums = new int[] {2,4,6,8};
        int target = 3;

        Console.WriteLine(solution.SearchInsert(nums, target));
    }
}

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target) return i;

            if (nums[i] < target && i == nums.Length-1)
                return i+1;

            if (nums[i] < target && nums[i+1] > target)
                return i+1;
        }
        return 0;
    }
}