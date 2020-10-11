using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/beautiful-arrangement-ii/
    /// 
    /// Given two integers n and k, you need to construct a list which contains n different positive integers ranging from 1 to n and obeys the following requirement:
    /// Suppose this list is [a_1, a_2, a_3, ... , a_n], then the list [|a_1 - a_2|, |a_2 - a_3|, |a_3 - a_4|, ... , |a_n-1 - a_n|] has exactly k distinct integers.
    /// 
    /// If there are multiple answers, print any of them.
    /// 
    /// Example 1:
    /// Input: n = 3, k = 1
    /// Output: [1, 2, 3]
    /// Explanation: The [1, 2, 3] has three different positive integers ranging from 1 to 3, and the [1, 1] has exactly 1 distinct integer: 1.
    /// 
    /// Example 2:
    /// Input: n = 3, k = 2
    /// Output: [1, 3, 2]
    /// Explanation: The [1, 3, 2] has three different positive integers ranging from 1 to 3, and the [2, 1] has exactly 2 distinct integers: 1 and 2.
    /// 
    /// Note:
    /// 
    /// 1. The n and k are in the range 1 <= k < n <= 10^4.
    /// 
    /// </summary>
    public class N0667_BeautifulArrangementIi
    {
        public class Solution1 {
            public int[] ConstructArray(int n, int k) {
                throw new NotImplementedException();
            }
        }
    }
}