using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SortVisualisator
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

