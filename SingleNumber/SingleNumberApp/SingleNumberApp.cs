using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumber.App
{
    public class SingleNumberApp
    {
        public int? SingleNumber(int[] nums)
        {
            int? singleNum = null;
            for(var i= 0; i<nums.Length; i++)
            {
                if(singleNum != null)
                {
                    break;
                }
                singleNum = nums[i];
                for (var j= 0; j < nums.Length; j++)
                {
                    if (i != j && singleNum == nums[j])
                    {
                        singleNum = null;
                    }
                }
            }
            
            return singleNum;
        }
    }
}
