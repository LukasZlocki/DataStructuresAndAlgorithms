namespace DataStructuresAndAlgorithms.Algorithms
{
    // Selection sort
    // Step by step algo description:
    // * [-11, 12, -42, 0, 1, 90, 68, 6, -9]
    // * Find lowest number and insert it on 0 possition in table , insert -11 value in possition where min value(-42) was found
    // * [-42 |, 12, -11, 0, 1, 90, 68, 6, -9]
    // * Find lowest number and insert it on 1 possition in table , insert 12 value in possition where next min value(-11) was found
    // * [-42, -11 |, 12, 0, 1, 90, 68, 6, -9]
    // * steps as above

    public class SelectionSorting {
        private int[] sortTable = new int[] {-11, 12, -42, 0, 1, 90, 68, 6, -9};

        public void Selection() {
            //int minValuePossition = 0;
            int minValue;
            int temporaryValue;

            for(int i = 0; i< sortTable.GetLength(0); i++) {
                minValue = sortTable[i];
                for (int j = i; j < sortTable.GetLength(0); j++) {
                    if (minValue >= sortTable[j]) {
                        minValue = sortTable[j];
                        temporaryValue = sortTable[i]; // this is value not longer min and need to be replaced
                        sortTable[i] = sortTable[j]; // moving new min value on beggining 
                        sortTable[j] = temporaryValue; // moving old min value to j possition
                    }

                }
            }
        }
    public void PrintTable(){
        for (int a = 0; a< sortTable.GetLength(0); a++) {
            Console.WriteLine("" + sortTable[a]);
        }
    } 
    
    }  
}

