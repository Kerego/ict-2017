using System.Threading.Tasks;
using Ict2017.Common.ViewModels;

namespace Ict2017.Common
{
    public interface IIctService
    {
        Task<GalleryItemViewModel> GetGalleryItemAsync(int page);
        Task<PresentationViewModelBase[]> GetPresentationsAsync();
        Task IncrementClapCountAsync(int id);
    }
}