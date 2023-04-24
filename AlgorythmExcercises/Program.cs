using Helpers;
using AlgorythmExcercises.SortingAlgorythms;

Console.WriteLine("Welcome to my Sorting Algorithm comparison Program!");

Console.Write("Enter the length of the list to compare: ");
int list_length = int.Parse(Console.ReadLine());
List<int> original_list = helper.Generate_list_of_integers(list_length);

Console.WriteLine($"You have chosen a list length of {list_length}.");
Console.WriteLine("Now, let's compare some sorting algorithms!");

Console.WriteLine("First let's see how bubblesort does!");
BubbleSort bubbleSort = new BubbleSort();
bubbleSort.Sort(original_list);
TimeSpan timeSpan = bubbleSort.RunTime.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds,
           timeSpan.Milliseconds / 2);

Console.WriteLine($"It took {bubbleSort.SwapCount} swaps and {elapsedTime} all together");

