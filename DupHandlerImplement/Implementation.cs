
namespace DupHanlderImplement
{
    internal class Implementation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Application");
        }
    }
}


namespace DuplicateHandlerNS
{
    /// <summary>
    /// Class <c>DuplicateHandler</c> is a handler used to remove duplicate elements in ICollections.
    /// </summary>
    public class DuplicateHandler<T>
    {
        public DuplicateHandler() { }

        /// <summary>
        /// This method accepts an ICollection and returns an ICollection instance without
        /// duplicates based on the elements that were passed in.
        /// </summary
        /// 
        /// <param name="checkCollection">The ICollection which will be checked for duplicate elements.</param>
        /// <returns>A new instance of the passed-in ICollection without any duplicates.</returns>
        public ICollection<T> RemoveDuplicates(ICollection<T> checkCollection)
        {
            return checkCollection.Distinct().ToList();
        }
    }
}