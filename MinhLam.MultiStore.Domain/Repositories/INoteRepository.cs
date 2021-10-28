using MinhLam.Framework;
using MinhLam.MultiStore.Domain.Entities;
using System.Collections.Generic;

namespace MinhLam.MultiStore.Domain.Repositories
{
    public interface INoteRepository : IRepositoryBase<Note>
    {
        public List<Note> GetAll();
    }
}
