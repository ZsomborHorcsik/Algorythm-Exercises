using System.Diagnostics;


namespace AlgorythmExcercises.SortingAlgorythms
{
    public class BubbleSort : SortingAlgorythm
    {
        public BubbleSort()
        {
            SwapCount = 0;
            RunTime = new Stopwatch();
        }

        public List<int> Sort(List<int> original_list)
        {
            RunTime.Start();
            for (int i = 0; i < original_list.Count - 1; i++)
            {
                for (int j = 0; j < original_list.Count - i - 1; j++)
                {
                    if (original_list[j] > original_list[j + 1])
                    {
                        // swap elements
                        int temp = original_list[j];
                        original_list[j] = original_list[j + 1];
                        original_list[j + 1] = temp;

                        SwapCount++;
                    }
                }
            }

            RunTime.Stop();

            return (original_list);
        }
    }
}