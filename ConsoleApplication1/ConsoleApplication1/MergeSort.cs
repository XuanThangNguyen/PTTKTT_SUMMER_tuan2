using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MergeSort
    {

        public static void Merge_Sort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Merge_Sort(A, left, mid);
                Merge_Sort(A, mid + 1, right);
                Merge(A, left, mid, right);
            }
        }
        static void Merge(int[] A, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
                L[i] = A[left + i];

            for (int j = 0; j < n2; j++)
                R[j] = A[mid + j + 1];

            int k = left;
            int iL = 0;
            int jR = 0;

            while (iL < n1 && jR < n2)
            {
                if (L[iL] <= R[jR])
                {
                    A[k] = L[iL];
                    iL++;
                }
                else
                {
                    A[k] = R[jR];
                    jR++;
                }
                k++;
            }

            while (iL < n1)
            {
                A[k] = L[iL];
                iL++;
                k++;
            }

            while (jR < n2)
            {
                A[k] = R[jR];
                jR++;
                k++;
            }
        }
    }
}
