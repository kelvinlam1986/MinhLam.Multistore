using MinhLam.Framework;
using System;

namespace MinhLam.MultiStore.Domain.Entities
{
    public class Note : AggregateRoot
    {
        public DateTime NoteDate { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string UserId { get; set; }
    }
}
