using System.Diagnostics;

namespace AlgorythmExcercises.SortingAlgorythms
{
    public class SelectionSort : SortingAlgorythm
    {
        public SelectionSort() 
        {
            SwapCount = 0;
            RunTime = new Stopwatch();
        }

        public List<int> Sort(List<int> original_list)
        {
            RunTime.Start();

            for (int i = 0; i < original_list.Count - 1; i++)
            {
                int min_index = i;

                for (int j = i + 1; j < original_list.Count; j++)
                {
                    if (original_list[j] < original_list[min_index])
                    {
                        min_index = j;
                    }
                }

                if (min_index != i)
                {
                    int temp = original_list[i];
                    original_list[i] = original_list[min_index];
                    original_list[min_index] = temp;

                    SwapCount++;
                }
            }

            RunTime.Stop();

            return original_list;
        }
    }
}
