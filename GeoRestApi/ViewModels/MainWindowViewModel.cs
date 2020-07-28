using System;
using System.ComponentModel;
using WorkMaps;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace GeoRestApi
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Clicks
        public DelegateCommand ClickSearch { get; private set; }
        public DelegateCommand ClickSave { get; private set; } 
        #endregion

        /// <summary>
        /// For Connect to Rest Api
        /// </summary>
        private Client<ServiceOSM> Client { get; set; }

        #region Properties for view
        public ObservableCollection<MapObject> Answers { get; set; }

        string address;
        public string Address
        {
            get => address;
            set
            {
                address = value;
                OnPropertyChanged("Address");
                ClickSearch.RaiseCanExecuteChanged();
            }
        }

        float polygons;
        public float Polygons
        {
            get => polygons;
            set
            {
                polygons = value;
                OnPropertyChanged("Polygons");
            }
        }

        byte limit;
        public byte Limit
        {
            get => limit;
            set
            {
                limit = value;
                OnPropertyChanged("Limit");
            }
        }
        #endregion
  
        string Answer { get; set; }
        SaveFileDialog saveFileDialog { get; set; }

        public MainWindowViewModel()
        {
            ClickSearch = new DelegateCommand(Search, CanSearch);
            ClickSave = new DelegateCommand(Save, CanSave);

            Client = new Client<ServiceOSM>();

            Answers = new ObservableCollection<MapObject>();

            saveFileDialog = new SaveFileDialog()
            {
                Filter = "json files(*.json)|*.json|text file(*.txt)|*.txt|all files(*.*)|*.*",
                FilterIndex = 1
            };
        }

        /// <summary>
        /// Search objects
        /// </summary>
        /// <param name="param"></param>
        private async void Search(object param)
        {
            try
            {
                Answer = await Client.Search(Address, Limit, Polygons);
                Answers.Clear();
                ParseJson(Answer);
                ClickSave.RaiseCanExecuteChanged();
            }
            catch (Exception ex)
            {
                Answer = "Error: " + ex.Message;
            }
        }
        private bool CanSearch(object param)
        {
            if (string.IsNullOrWhiteSpace(Address)) return false;
            return true;
        }

        /// <summary>
        /// Save response
        /// </summary>
        /// <param name="param"></param>
        private async void Save(object param)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == true)
                    await File.WriteAllTextAsync(saveFileDialog.FileName, Answer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool CanSave(object param)
        {
            if (Answers.Count == 0) return false;
            return true;
        }

        /// <summary>
        /// parsing json
        /// </summary>
        /// <param name="json"></param>
        private void ParseJson(string json)
        {
            JArray jObjects = JArray.Parse(json);

            foreach (JObject jObj in jObjects)
            {
                string title = jObj["display_name"].ToString();
                MapObject mapObject = new MapObject(title);
                Answers.Add(mapObject);
            }
        }

        /// <summary>
        /// for mvvm
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
