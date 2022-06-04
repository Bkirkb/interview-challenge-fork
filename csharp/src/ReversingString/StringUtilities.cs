namespace CodingChallenge.ReversingString;

public class StringUtilities
{
    // Method can be made more durable by changing input to an object, dealing with things other than string and Null
    public static string Reverse(string s)
    {
        
        string reversedString = string.Empty;
        if (string.IsNullOrEmpty(s))
        {
            return "String is null or empty";
        }
        else
        {
            char[] inputChars = s.ToCharArray();
            try
            {
                for (int i = inputChars.Length - 1; i >= 0; i--)
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
}
