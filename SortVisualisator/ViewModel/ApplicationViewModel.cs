using System.ComponentModel;
using System.Runtime.CompilerServices;
using SortVisualisator._App;

namespace SortVisualisator.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private AnimationState _state;

        public AnimationState State
        {
            get => _state;
            set { _state = value; OnPropertyChanged("State"); }
        }

        private RelayCommand _changeStateCommand;
        public RelayCommand ChangeStateCommand
        {
            get
            {
                return _changeStateCommand ??
                       (_changeStateCommand = new RelayCommand(obj =>
                       {
                           State = AnimationState.Pause;
                       }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

    public enum AnimationState
    {
        Sort,
        Pause,
        Resume,
        Shuffle
    }
}

