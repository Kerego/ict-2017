using System;
using System.Linq;
using System.Threading.Tasks;
using Ict2017.Common.Models;
using Ict2017.Common.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Ict2017.Common
{
    public class IctService : IIctService
    {
        private readonly IctDbContext dbContext;

        public IctService(IctDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        protected static Func<IctDbContext, AsyncEnumerable<PresentationViewModelBase>> PresentationsQueryAsync =
            EF.CompileAsyncQuery((IctDbContext context) => context.Presentations
                .Select(x => new PresentationViewModelBase
                {
                    Id = x.Id,
                    Title = x.Title,
                    ClapCount = x.ClapCount,
                    Presenter = x.Presenter.Forename + " " + x.Presenter.Surname,
                    Description = x.Description,
                    StartTime = x.Start,
                    EndTime = x.End
                }));

        protected static Func<IctDbContext, int, Task<GalleryItemViewModel>> GalleryItemQueryAsync =
            EF.CompileAsyncQuery((IctDbContext context, int page) => context.Assets
                .Where(x => x.Type == AssetType.Image && x.Id == page)
                .Select(x => new GalleryItemViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Location = x.Location,
                    NextExists = x.Id < 15,
                    PreviousExists = x.Id > 1
                })
                .First());

        public Task<PresentationViewModelBase[]> GetPresentationsAsync() =>
            PresentationsQueryAsync(dbContext).ToArrayAsync();

        public Task<GalleryItemViewModel> GetGalleryItemAsync(int page) =>
            GalleryItemQueryAsync(dbContext, page);

        public async Task IncrementClapCountAsync(int id)
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                var presentation = await dbContext.Presentations.FindAsync(id);
                presentation.ClapCount++;
                await dbContext.SaveChangesAsync();
                transaction.Commit();
            }
        }
    }
}