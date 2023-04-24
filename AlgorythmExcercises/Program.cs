using Helpers;
using SortingAlgorythms;

Console.WriteLine("Welcome to my Sorting Algorithm comparison Program!");

Console.Write("Enter the length of the list to compare: ");
int list_length = int.Parse(Console.ReadLine());
List<int> original_list = helper.Generate_List_of_integers(list_length);

Console.WriteLine($"You have chosen a list length of {list_length}.");
Console.WriteLine($"Your original list looks like this {original_list}.");
Console.WriteLine("Now, let's compare some sorting algorithms!");

Console.WriteLine("First let's see how bubblesort does!");
BubbleSort bubbleSort = new BubbleSort();
List<int> sorted_list = bubbleSort.Sort(original_list);
Console.WriteLine($"{sorted_list}");
Console.WriteLine($"It took {bubbleSort.SwapCount} swaps and {bubbleSort.RunTime} all together");

