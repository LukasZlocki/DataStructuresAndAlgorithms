using DataStructuresAndAlgorithms.Algorithms;
using DataStructuresAndAlgorithms.DataStructure;


SelectionSorting ss2 = new SelectionSorting();
ss2.Selection();
DoubleSpacer();



// One dimension array - extracting names of months
Console.WriteLine("One dimension array - extracting names of months");
ArrayOneDimension arrayOneDimension = new ArrayOneDimension();
arrayOneDimension.CreateOneDomensionArray();
arrayOneDimension.PresentData();
DoubleSpacer();

// Multi dimension array - multiplication table
Console.WriteLine("Multi dimension array - multiplication table");
ArrayMultiDimension arrayMultiDimension = new ArrayMultiDimension();
arrayMultiDimension.GenerateMultipleTable();
arrayMultiDimension.ShowResultsOnScreen();
DoubleSpacer();



void DoubleSpacer() {
    Console.WriteLine();
    Console.WriteLine();
}