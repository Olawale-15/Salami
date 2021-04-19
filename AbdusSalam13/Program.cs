using System;  
public class AbdusSalam13
{  
    public static void Main() 
      {          
                    string line = "He is the best.";
                    string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
                        string word = "";
                        int check = 0;
                        foreach (String world in words)
                        {
                            if (world.Length > check)
                            {
                                word = world;
                                check = world.Length;
                            }
                        }
                   
                        Console.WriteLine(word);
                    
    }
}

