namespace DataStructuresAndAlgorithms.DataStructure
{

public class ArrayOneDimension
{ 
    string[] months = new string[12];
    
    public void CreateOneDomensionArray(){
        
        for (int month = 1; month < 12; month++ ){
            DateTime monthName = new DateTime(2020, month, 1);
            months[month] = monthName.ToString("MMMM");
        }
    }

    public void PresentData(){
        foreach(string element in months){
            Console.WriteLine($"{element}");
        }
    }
}

}