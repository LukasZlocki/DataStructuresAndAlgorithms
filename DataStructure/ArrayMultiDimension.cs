namespace DataStructuresAndAlgorithms.DataStructure
{
    public class ArrayMultiDimension
    {
        int[,] multiplyTable = new int [10,10];

            public void GenerateMultipleTable() {
                for (int i = 0; i < multiplyTable.GetLength(0); i++) {
                    for(int j = 0; j < multiplyTable.GetLength(1); j++){
                        multiplyTable[i, j] = (i+1) * (j+1);
                    }
                }
            }

            public void ShowResultsOnScreen(){
                for (int i = 0; i < multiplyTable.GetLength(0); i++){
                    for(int j = 0; j < multiplyTable.GetLength(1); j++){
                        Console.Write(" " + multiplyTable[i, j]);
                    }
                    Console.WriteLine();
                }
            }

   
    }   
}