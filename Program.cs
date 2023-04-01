using DataStructuresAndAlgorithms.Algorithms;
using DataStructuresAndAlgorithms.DataStructure;
using Hash;

// Hashtable | reversing 
HashReverse hashTbl = new HashReverse();
hashTbl.SetHashtable();

Console.WriteLine("Hash table before reversing:");
hashTbl.ShowHashtable();
Console.WriteLine("Reversing hash table, result :");
hashTbl.ReverseHashtable();
hashTbl.ShowHashtable();



DoubleSpacer(); // space between the lines


// selection sort 
SelectionSorting ss2 = new SelectionSorting();
Console.WriteLine("Table before sorting:");
ss2.PrintTable();
Console.WriteLine("Table after sorting");
ss2.Selection();
ss2.PrintTable();


DoubleSpacer(); // space between the lines


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