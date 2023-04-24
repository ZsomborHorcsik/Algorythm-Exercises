using AlgorythmExcercises.SortingAlgorythms;

namespace Helpers
{
    public static class helper
    {
        public static List<int> Generate_list_of_integers(double length)
        {
            Random rand = new Random();
            List<int> result = new List<int>();

            for (double i = 0; i < length; i++)
            {
                result.Add(rand.Next());
            }

            return result;
        }

        public static string Print_results_of_sorting(SortingAlgorythm algorythm)
        {
            TimeSpan timeSpan = algorythm.RunTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                       timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds,
                       timeSpan.Milliseconds / 2);

            return $"It took {algorythm.SwapCount} swaps and {elapsedTime} all together";
        }
    }
}