using System;
using System.Linq;
using System.Collections.Generic;


namespace биллиг1 
{ 
    public class solution
    {
        public static List <int> Eratosfen(int end)
        {           
            int count = 0;
            List<int> result1=new List<int>() {1} ;
            for (int i = 2; i <= end; i++)
            {
                foreach (int j in result1)
                    if (i % j == 0)
                    {
                        count++;
                    }
                if (count > 1)
                {
                    count = 0;
                    continue;
                }                                                                  
                result1.Add(i);                                  
                count = 0;
            }               
            return result1;
        }
        public static void Filter(List<int>list,int begin)
        {
             list.RemoveAll(p => p<begin);            
        }
        public static int MaxDiff1(List<int> list)
        {
            int Diff = 0;

            for (int i = 0; i < list.Count-1; i++)
            {
                if(Diff < list[i + 1] - list[i])
                {
                    Diff = list[i + 1] - list[i];
                }

            }
            return Diff; 
        }
        public static int[] MaxSimpleNum(List<int> list)
        {
            int[] nums = new int[2] {0,1};
            int count = 0;                        
            for (int i = 1; i < (list.Count/10)+1; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] < i * 10 || list[j] > (i - 1) * 10) count++;
                }
                if(nums[0]<count)nums[0] = count;nums[1] = i;
            }
            return nums;
        }
        public static int[] MinSimpleNum(List<int> list)
        {
            int[] nums = new int[2] { 9, 1 };
            int count = 0;
            for (int i = 1; i < (list.Count / 10) + 1; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] < i * 10 || list[j] > (i - 1) * 10) count++;
                }
                if (nums[0] > count) nums[0] = count; nums[1] = i;
            }
            return nums;
        }




    }
}
