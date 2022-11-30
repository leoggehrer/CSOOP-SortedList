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
        private Element? first = null;
        /// <summary>
        /// Calculates the number of elements in the list.
        /// </summary>
        public int Count
        {
            get
            {
                int result = 0;
                Element? run = first;

                while (run != null)
                {
                    result++;
                    run = run.Next;
                }
                return result;
            }
        }

        /// <summary>
        /// Inserts the value into the list in ascending order.
        /// </summary>
        /// <param name="value">The value to insert.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Insert(int value)
        {
            if (first == null)  // Case A: the list is empty
            {
                first = new Element(value, first);
            }
            else if (value < first.Data) // Case B: Insert the element before the first element.
            {
                first = new Element(value, first);
            }
            else // Case C and Case D : Insert the item in the list (Case C) or at the end (Case D).
            {
                Element? run = first;

                while (run != null && run.Next != null && run.Next.Data < value)
                {
                    run = run.Next;
                }
                run!.Next = new Element(value, run.Next);
            }
        }
        /// <summary>
        /// Removes the position [0..Count-1], otherwise an IndexOutOfRange is thrown.
        /// </summary>
        /// <param name="position">The position [0..Count-1] in the list.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Remove(int position)
        {
            if (position < 0 || position >= Count)
                throw new IndexOutOfRangeException();

            if (position == 0)
            {
                first = first!.Next;
            }
            else
            {
                int idx = 0;
                Element? run = first;

                while (run != null && idx != position - 1)
                {
                    idx++;
                    run = run.Next;
                }
                run!.Next = run!.Next!.Next;
            }
        }
        /// <summary>
        /// Returns the value at the lite position to the caller.
        /// </summary>
        /// <param name="position">The position [0..Count-1] in the list.</param>
        /// <returns>The value at the position, otherwise an IndexOutOfRange is thrown.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GetAt(int position)
        {
            if (position < 0 || position >= Count)
                throw new IndexOutOfRangeException();

            int idx = 0;
            Element? run = first;

            while (run != null && idx != position)
            {
                idx++;
                run = run.Next;
            }
            return run!.Data;
        }
    }
}
