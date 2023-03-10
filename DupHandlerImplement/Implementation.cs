
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
        /// duplicates in the original list.
        /// </summary
        /// 
        /// <param name="checkCollection">The ICollection which will be checked for duplicate elements.</param>
        /// <returns>An instance of the passed-in ICollection without any duplicates.</returns>
        public ICollection<T> RemoveDuplicates(ICollection<T> checkCollection)
        {
            return checkCollection.Distinct().ToList();
        }
    }
}