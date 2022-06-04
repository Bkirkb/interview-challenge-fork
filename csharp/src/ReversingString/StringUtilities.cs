namespace CodingChallenge.ReversingString;

public class StringUtilities
{
    public static string Reverse(string s)
    {
        char[] inputChars = s.ToCharArray();
        string reversedString = string.Empty;
        try
        {
            for(int i = inputChars.Length - 1; i >= 0; i--)
            {
                reversedString += inputChars[i];
            }
        }
        catch
        {
            throw new ArgumentException("Input should be a string with a length of more than 1");
        }
        return reversedString;
    }
}
