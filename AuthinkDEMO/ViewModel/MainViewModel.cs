using AuthinkDEMO.Views.ChildlrenListView;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

using AuthinkDEMO.Services;
using AuthinkDEMO.Views;
using Windows.Storage;
using AuthinkDEMO.Settings.Language;

namespace AuthinkDEMO.ViewModel
{
    public partial class MainViewModel : ViewModelBase
    {
        public string MainMenuContent
        {
            get { return _mainMenuContent; }
            set
            {
                if (_mainMenuContent == value)
                {
                    return;
                }

                _mainMenuContent = value;
                this.RaisePropertyChanged(this.MainMenuContent);
            }
        }
        private string _mainMenuContent = Language.Mainpage.MainMenuContent();

        public string PlayButtonContent
        {
            get { return _playButtonContent; }
            set
            {
                if (_playButtonContent == value)
                {
                    return;
                }

                _playButtonContent = value;
                this.RaisePropertyChanged(this.PlayButtonContent);
            }
        }
        private string _playButtonContent = Language.Mainpage.PlayButtonContent();
        
        public string SettingsButtonContent
        {
            get { return _settingsButtonContent; }
            set
            {
                if (_settingsButtonContent == value)
                {
                    return;
                }

                _settingsButtonContent = value;
                this.RaisePropertyChanged(this.SettingsButtonContent);
            }
        }
        private string _settingsButtonContent = Language.Mainpage.SettingsButtonContent();
        
        public string AboutButtonContent
        {
            get { return _aboutButtonContent; }
            set
            {
                if (_aboutButtonContent == value)
                {
                    return;
                }

                _aboutButtonContent = value;
                this.RaisePropertyChanged(this.AboutButtonContent);
            }
        }
        private string _aboutButtonContent = Language.Mainpage.AboutButtonContent();
        
        public string BackButtonContent
        {
            get { return _backButtonContent; }
            set
            {
                if (_backButtonContent == value)
                {
                    return;
                }

                _backButtonContent = value;
                this.RaisePropertyChanged(this.BackButtonContent);
            }
        }
        private string _backButtonContent = Language.Mainpage.BackButtonContent();

        public RelayCommand PlayCommand { get; private set; }
        private void Play()
        {
            _navigationService.NavigateTo(typeof(TestListView));
        }

        public RelayCommand SettingsCommand { get; private set; }
        private void Settings()
        {
            _navigationService.NavigateTo(typeof(SettingsView));
        }

        public RelayCommand AboutCommand { get; private set; }
        private void About()
        {
            _navigationService.NavigateTo(typeof (AboutView));
        }

        public RelayCommand BackCommand { get; set; }
        private void Back()
        {
            ApplicationData.Current.LocalSettings.Values["SelectedChildId"] = null;
            _navigationService.NavigateTo(typeof (ChildrenView));
        }
    }

    public partial class MainViewModel
    {
        private readonly NavigationService _navigationService;
        
        public MainViewModel
        (
            NavigationService navigationService
        )
        {
            _navigationService = navigationService;
            
            this.PlayCommand      = new RelayCommand(Play);
            this.SettingsCommand  = new RelayCommand(Settings);
            this.AboutCommand     = new RelayCommand(About);
            this.BackCommand    = new RelayCommand(Back);
        }
    }
}