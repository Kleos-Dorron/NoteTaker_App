using NoteTaker_App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaker_App.ViewModels
{
    public class NotesViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Note> Notes { get; set; }

        public NotesViewModel()
        {
            Notes = new ObservableCollection<Note>
            {
                new Note { Title = "Sample Note", Content = "This is a sample note.", DateCreated = DateTime.Now }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
