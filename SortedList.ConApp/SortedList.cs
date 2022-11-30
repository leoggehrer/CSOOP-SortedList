namespace SortedList.ConApp
{
    public class SortedList
    {
        private class Element
        {
            public int Data { get; set; }
            public Element? Next { get; set; }
            public Element(int data, Element? next)
            {
                Data = data;
                Next = next;
            }
        }

        /// <summary>
        /// Calculates the number of elements in the list.
        /// </summary>
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Inserts the value into the list in ascending order.
        /// </summary>
        /// <param name="value">The value to insert.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Insert(int value)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Removes the position [0..Count-1], otherwise an IndexOutOfRange is thrown.
        /// </summary>
        /// <param name="position">The position [0..Count-1] in the list.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Remove(int position)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Returns the value at the lite position to the caller.
        /// </summary>
        /// <param name="position">The position [0..Count-1] in the list.</param>
        /// <returns>The value at the position, otherwise an IndexOutOfRange is thrown.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GetAt(int position)
        {
            throw new NotImplementedException();
        }
    }
}
