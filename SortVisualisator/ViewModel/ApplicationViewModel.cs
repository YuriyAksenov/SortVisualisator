using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SortVisualisator.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        public string AnimationState { get; set; } = "Start";

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

    enum AnimationState
    {
        Sort,
        Pause,
        Resume,
        Shuffle
    }
}

