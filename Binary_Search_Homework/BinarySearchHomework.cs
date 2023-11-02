using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                               // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                               // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                               // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            int Left = 0;
            int Right = arr.Length - 1;

            while (Left <= Right)
            {
                int mid1 = Left + (Right - Left) / 3;
                int mid2 = Right - (Right - Left) / 3;

                if (arr[mid1] == key) return mid1;

                if (arr[mid2] == key) return mid2;

                if (key < arr[mid1]) Right = mid1 - 1;

                else if (key > arr[mid2]) Left = mid2 + 1;

                else { Left = mid1 + 1; Right = mid2 - 1; }
            }
            return -1;
        }

       

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            int count = 0;
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == key)
                {
                    count++;
                    int i = mid - 1;
                    while (i >= left && arr[i] == key) { count++; i--; }
                    int j = mid + 1;
                    while (j <= right && arr[j] == key) { count++; j++; }
                    return count;
                }
                else if (arr[mid] < key) left = mid + 1;
                else right = mid - 1;
            }
            return count;
        }
    }
}
