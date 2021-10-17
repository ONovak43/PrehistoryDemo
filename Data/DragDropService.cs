using System.Collections.Generic;

namespace PrehistoryMethodApp.Data
{
    internal class DragDropService<T>
    {
        public T ActiveItem { get; set; }
        public T LastActiveItem { get; set; }
        public bool ForcedEnd { get; set; }
        public bool SuccessfulEnd { get; set; }
        public List<T> Items { get; set; }
        public void Reset()
        {
            ActiveItem = default;
            LastActiveItem = default;
            Items = null;
            ForcedEnd = default;
            SuccessfulEnd = default;
        }
    }
}
