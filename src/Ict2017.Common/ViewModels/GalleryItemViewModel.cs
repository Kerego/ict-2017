namespace Ict2017.Common.ViewModels
{
    public class GalleryItemViewModel : ViewModelBase
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public bool PreviousExists { get; set; }
        public bool NextExists { get; set; }
    }
}