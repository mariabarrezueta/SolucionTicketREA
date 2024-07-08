using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using MauiTicketREA.Models;
using MauiTicketREA.Services;
using Microsoft.Maui.Controls;

namespace MauiTicketREA.ViewModels
{
    public class EventViewModel : BindableObject
    {
        private readonly ApiService _apiService;
        private readonly SQLiteDatabase _database;

        public ObservableCollection<DetailEvent> Events { get; }

        public ICommand LoadEventsCommand { get; }

        public EventViewModel()
        {
            _apiService = new ApiService();
            _database = new SQLiteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "events.db3"));
            Events = new ObservableCollection<DetailEvent>();

            LoadEventsCommand = new Command(async () => await LoadEventsAsync());
            Task.Run(async () => await LoadEventsAsync());
        }

        private async Task LoadEventsAsync()
        {
            var events = await _apiService.GetEventsAsync();
            foreach (var detailEvent in events)
            {
                await _database.SaveEventAsync(detailEvent);
            }

            var storedEvents = await _database.GetEventsAsync();
            Events.Clear();
            foreach (var detailEvent in storedEvents)
            {
                Events.Add(detailEvent);
            }
        }
    }
}


