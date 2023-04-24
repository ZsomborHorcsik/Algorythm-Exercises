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
Console.WriteLine(helper.Print_results_of_sorting(bubbleSort));

Console.WriteLine("Now let's see how insertionsort does!");
InsertionSort insertionSort = new InsertionSort();
insertionSort.Sort(original_list);
Console.WriteLine(helper.Print_results_of_sorting(insertionSort));


