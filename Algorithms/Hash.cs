using System.Collections;

namespace Hash{

    public class HashReverse {
        Hashtable hashtbl = new Hashtable ();


        public void SetHashtable(){
            hashtbl.Add("wlt", "Wielton");
            hashtbl.Add("kru", "Kruk");
            hashtbl.Add("kgh", "KGHM");
            hashtbl.Add("pko", "PKO");
        }

        public void ShowHashtable(){
            foreach(DictionaryEntry element in hashtbl) {
                Console.WriteLine("Hash table | Key : {0} | Value : {1}", element.Key, element.Value);
            }
        }

    }   

}