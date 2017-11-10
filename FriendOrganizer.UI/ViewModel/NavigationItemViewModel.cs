using System.Windows.Input;
using FriendOrganizer.UI.Event;
using Prism.Commands;
using Prism.Events;

namespace FriendOrganizer.UI.ViewModel
{
    public class NavigationItemViewModel : ViewModelBase
    {
        private string _displayMember;
        private  readonly IEventAggregator _eventAggregator;
        private readonly string _detailViewModelName;

        public NavigationItemViewModel(int id, string displayMember,string detailViewModelName ,IEventAggregator eventAggregator)
        {
            Id = id;
            DisplayMember = displayMember;
            OpenDetailViewCommand = new DelegateCommand(OnOpenDetailViewExecute);
            _eventAggregator = eventAggregator;
            _detailViewModelName = detailViewModelName;
        }

        

        public int Id { get; set; }
        

        public string DisplayMember
        {
            get { return _displayMember; }
            set
            {
                _displayMember = value;
                OnPropertyChanged();
            }
        }

        public ICommand OpenDetailViewCommand { get;}
         
        private void OnOpenDetailViewExecute()
        {
            _eventAggregator.GetEvent<OpenDetailViewEvent>().Publish(
                new OpenDetailViewEventArgs
                {
                    Id = Id,
                    ViewModelName =_detailViewModelName
                });
        }

    }
}
