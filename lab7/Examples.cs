namespace Examples;

public class Hints {

    public static void dictionary()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        dict.Add("Programming", 90);
        dict.Add("Management", 70);
        dict.Add("Databases", 60);
        dict.Add("Accounting", 45);
        
        // iterate over dictionary. each item in the 
        // dictionary is a key/value pair. 

        foreach(KeyValuePair<string, int> pair in dict) {
            Console.WriteLine($"{pair.Key} is {pair.Value}");
        }

    }

    public static void strings() 
    {
        // you can create a string from a char array
        string someStr = new string(new char[]{'h', 'e', 'l', 'l', 'o'});
        Console.WriteLine(someStr);
    }


}