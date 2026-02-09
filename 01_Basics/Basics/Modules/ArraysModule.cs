using System;

public class ArraysModule : IPracticeModule
{
    public string Name => "Arrays";

    public void ShowMenu()
    {
        Console.WriteLine("\n--- Arrays Problems ---");
        Console.WriteLine("1. Reverse Array");
        Console.WriteLine("2. Find Max Element");
        Console.WriteLine("3. Find Two Sum");
        Console.WriteLine("4. Move Zeroes");
        Console.WriteLine("0. Back");

        int choice = int.Parse(Console.ReadLine()!);
        Execute(choice);
    }

    public void Execute(int choice)
    {
        switch (choice)
        {
            case 1: ReverseArray(); break;
            case 2: FindMax(); break;
            case 3: TwoSum(); break;
            case 4: MoveZeroes(); break;
        }
    }

    void ReverseArray()
    {
        int[] arr = InputHelper.ReadIntArray();
        Array.Reverse(arr);
        Console.WriteLine("Result: " + string.Join(",", arr));
    }

    void FindMax()
    {
        int[] arr = InputHelper.ReadIntArray();
        int max = arr[0];

        foreach (var n in arr)
            if (n > max) max = n;

        Console.WriteLine("Max: " + max);
    }

    void TwoSum()
    {
      int[] nums =InputHelper.ReadIntArray();
      Console.WriteLine("Enter Target: ");
      int target =int.Parse(Console.ReadLine()!);

    //   Dictionary<int,int>  map =new Dictionary<int,int>();
      var  map =new Dictionary<int,int>();

      for(int i=0;i<nums.Length;i++)
      {
        int needed =target - nums[i];
        if(map.ContainsKey(needed)){
            Console.WriteLine($"Indices: {map[needed]}, {i}");
            return;
        }
  // store number with its index
        map[nums[i]] = i;
      }
     Console.WriteLine("No solution found");

    }


    void MoveZeroes(){
        int[] nums = InputHelper.ReadIntArray();
        int index=0;

        for(int i=0;i<nums.Length;i++){

            if(nums[i]!=0){
                nums[index]= nums[i];
                index++;
            }
        }
        for(int i=index;i<nums.Length;i++){
            nums[i] =0;
        }
      Console.WriteLine("Result "+string.Join(',',nums));
    }
}
