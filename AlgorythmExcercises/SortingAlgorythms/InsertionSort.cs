using System.Diagnostics;

namespace AlgorythmExcercises.SortingAlgorythms
{
    public class Insertion_Sort : SortingAlgorythm
    {
        public Insertion_Sort() 
        {
            SwapCount = 0;
            RunTime = new Stopwatch();
        }

        public List<int> Sort(List<int> original_list)
        {
            RunTime.Start();

            for (int i = 1; i < original_list.Count; i++)
            {
                int key = original_list[i];
                int j = i - 1;

                while (j >= 0 && original_list[j] > key)
                {
                    original_list[j + 1] = original_list[j];
                    j--;
                    SwapCount++;
                }

                original_list[j + 1] = key;
            }

            RunTime.Stop();
            return original_list;
        }
    }
}
