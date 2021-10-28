using MinhLam.MultiStore.Domain.Entities;
using MinhLam.MultiStore.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MinhLam.Multistore.Infrastructure.Repositories
{
    public class NoteRepository : RepositoryBase<Note>, INoteRepository
    {
        public NoteRepository(MultiStoreContext dbContext) : base(dbContext)
        {
        }

        public List<Note> GetAll()
        {
            return DbContext.Notes.ToList();
        }
    }
}
