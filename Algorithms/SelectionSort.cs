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

    public class SelectionSort
    {
        int[] sortTable = new int[] {-11, 12, -42, 0, 1, 90, 68, 6, -9};

        public void SelectionSorting(){
            int minValue = sortTable[0];
            int lastPositionMinValue = 0;

            for (int i = 0; i < sortTable.GetLength(0); i++){
                for(int j = i; j < sortTable.GetLength(0); j++ ){
                    if (sortTable[j] < minValue){
                        minValue = sortTable[j];
                        lastPositionMinValue = j;
                    }
                }
                // insert checked value into possition where min value was found
                sortTable[lastPositionMinValue] = sortTable[i];

                // insert min value to first possition.
                sortTable[i] = minValue;
            }
        }


    }
}