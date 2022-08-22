// Dada uma matriz de inteiros nums e um inteiro target, retorne os índices dos dois números de forma que a soma seja igual atarget .

//Você pode assumir que cada entrada teria exatamente uma solução e não pode usar o mesmo elemento duas vezes.

class Program{
    static void Main(string[] args){
        var result = new Solution();
        int []nums =  new int[] {2,7,11,15};
        int target = 9;
        Console.WriteLine(result.TwoSum(nums, target));
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            int temp = target - nums[i];
            for (int j = i+1; j < nums.Length; j++)
                if (temp == nums[j])
                    return new int[] {i, j};
        }
        return nums;  
    }
}
