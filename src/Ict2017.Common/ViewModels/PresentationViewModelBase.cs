using System;

namespace Ict2017.Common.ViewModels
{
    public class PresentationViewModelBase : ViewModelBase
    {
        public string Title { get; set; }
        public string Presenter { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public int ClapCount { get; set; }
    }
}