﻿using Helpers;
using AlgorythmExcercises.SortingAlgorythms;

Console.WriteLine("Welcome to my Sorting Algorithm comparison Program!");

Console.Write("Enter the length of the list to compare: ");
int list_length = int.Parse(Console.ReadLine());
List<int> original_list = helper.Generate_list_of_integers(list_length);

Console.WriteLine($"You have chosen a list length of {list_length}.");
Console.WriteLine("Now, let's compare some sorting algorithms!");

Console.WriteLine("First let's see how bubble sort does!");
List<int> bubble_sort_list = new List<int>(original_list).ToList();
BubbleSort bubbleSort = new BubbleSort();
bubbleSort.Sort(bubble_sort_list);
Console.WriteLine(helper.Print_results_of_sorting(bubbleSort));

Console.WriteLine("Now let's see how insertion sort does!");
List<int> insertion_sort_list = new List<int>(original_list).ToList();
InsertionSort insertionSort = new InsertionSort();
insertionSort.Sort(insertion_sort_list);
Console.WriteLine(helper.Print_results_of_sorting(insertionSort));

Console.WriteLine("Now let's see how selection sort does!");
List<int> selection_sort_list = new List<int>(original_list).ToList();
SelectionSort selectionSort = new SelectionSort();
selectionSort.Sort(selection_sort_list);
Console.WriteLine(helper.Print_results_of_sorting(selectionSort));


