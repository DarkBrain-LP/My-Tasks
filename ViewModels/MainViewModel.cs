using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTasks.ViewModels
{
    public partial class MainViewModel: ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;
            Items.Add(text); 
            // Adding the item intered by user
            Text = String.Empty;
        }

        [RelayCommand]
        void Delete(string item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
        }
    }
}
