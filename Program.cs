using System.Globalization;

public class Program
{
    public static void Main(string[] args){
        
        bool result = IsSubsequence("ace", "abcde");
        Console.WriteLine(result);
        Console.ReadLine();
    }

    public static bool IsSubsequence(string s, string t){

        int i = 0; int j = 0;

        while(i < s.Length && j < t.Length){
            if(s[i] == t[j]){
                i++;
                j++;
    }
            else{
               j++; 
            }
        }

        return i == s.Length;
    }
}