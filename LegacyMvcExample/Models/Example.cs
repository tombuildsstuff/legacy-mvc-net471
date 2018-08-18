namespace LegacyMvcExample.Models
{
    public class Example
    {

        public Example(string message)
        {

            Message = message;
        }

        public string Message { get; private set; }
    }
}